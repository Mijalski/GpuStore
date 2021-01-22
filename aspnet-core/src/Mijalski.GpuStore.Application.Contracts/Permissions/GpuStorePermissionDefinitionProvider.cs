using Mijalski.GpuStore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Mijalski.GpuStore.Permissions
{
    public class GpuStorePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(GpuStorePermissions.GroupName);

            var booksPermission = myGroup.AddPermission(GpuStorePermissions.GraphicsCards.Default, L("Permission:GraphicsCards"));
            booksPermission.AddChild(GpuStorePermissions.GraphicsCards.Create, L("Permission:GraphicsCards.Create"));
            booksPermission.AddChild(GpuStorePermissions.GraphicsCards.Edit, L("Permission:GraphicsCards.Edit"));
            booksPermission.AddChild(GpuStorePermissions.GraphicsCards.Delete, L("Permission:GraphicsCards.Delete"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<GpuStoreResource>(name);
        }
    }
}
