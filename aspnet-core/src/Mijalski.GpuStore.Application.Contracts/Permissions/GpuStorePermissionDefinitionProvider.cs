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

            var gpuPermissions = myGroup.AddPermission(GpuStorePermissions.GraphicsCards.Default, L("Permission:GraphicsCards"));
            gpuPermissions.AddChild(GpuStorePermissions.GraphicsCards.Create, L("Permission:GraphicsCards.Create"));
            gpuPermissions.AddChild(GpuStorePermissions.GraphicsCards.Edit, L("Permission:GraphicsCards.Edit"));
            gpuPermissions.AddChild(GpuStorePermissions.GraphicsCards.Delete, L("Permission:GraphicsCards.Delete"));

            var contactMessages = myGroup.AddPermission(GpuStorePermissions.ContactMessages.Default, L("Permission:ContactMessages"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<GpuStoreResource>(name);
        }
    }
}
