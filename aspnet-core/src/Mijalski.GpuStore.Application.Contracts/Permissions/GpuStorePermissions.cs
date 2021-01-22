namespace Mijalski.GpuStore.Permissions
{
    public static class GpuStorePermissions
    {
        public const string GroupName = "GpuStore";

        public static class GraphicsCards
        {
            public const string Default = GroupName + ".GraphicsCards";
            public const string Create = Default + ".Create";
            public const string Edit = Default + ".Edit";
            public const string Delete = Default + ".Delete";
        }
    }
}