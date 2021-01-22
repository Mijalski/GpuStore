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

            //Define your own permissions here. Example:
            //myGroup.AddPermission(GpuStorePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<GpuStoreResource>(name);
        }
    }
}
