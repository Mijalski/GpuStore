using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Mijalski.GpuStore.Localization;
using Mijalski.GpuStore.Permissions;
using Volo.Abp.Account.Localization;
using Volo.Abp.UI.Navigation;
using Volo.Abp.Users;

namespace Mijalski.GpuStore.Blazor.Menus
{
    public class GpuStoreMenuContributor : IMenuContributor
    {
        private readonly IConfiguration _configuration;

        public GpuStoreMenuContributor(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
            else if (context.Menu.Name == StandardMenus.User)
            {
                await ConfigureUserMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            var l = context.GetLocalizer<GpuStoreResource>();

            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    GpuStoreMenus.Home,
                    l["Menu:Home"],
                    "/",
                    icon: "fas fa-home"
                )
            );

            var gpuStoreMenu = new ApplicationMenuItem(
                "GraphicsCardsStore",
                l["Menu:GraphicsCardStore"],
                icon: "fa fa-microchip"
            );

            context.Menu.AddItem(gpuStoreMenu);

            if (await context.IsGrantedAsync(GpuStorePermissions.GraphicsCards.Default))
            {
                gpuStoreMenu.AddItem(new ApplicationMenuItem(
                    "GpuStore.GraphicsCards",
                    l["Menu:GraphicsCards"],
                    url: "/graphicsCards"
                ));
            }
        }

        private Task ConfigureUserMenuAsync(MenuConfigurationContext context)
        {
            var accountStringLocalizer = context.GetLocalizer<AccountResource>();
            var currentUser = context.ServiceProvider.GetRequiredService<ICurrentUser>();

            var identityServerUrl = _configuration["AuthServer:Authority"] ?? "";

            if (currentUser.IsAuthenticated)
            {
                context.Menu.AddItem(new ApplicationMenuItem(
                    "Account.Manage",
                    accountStringLocalizer["ManageYourProfile"],
                    $"{identityServerUrl.EnsureEndsWith('/')}Account/Manage?returnUrl={_configuration["App:SelfUrl"]}",
                    icon: "fa fa-cog",
                    order: 1000,
                    null));
            }

            return Task.CompletedTask;
        }
    }
}
