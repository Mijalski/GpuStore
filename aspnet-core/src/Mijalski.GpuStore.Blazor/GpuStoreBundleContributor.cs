using Volo.Abp.Bundling;

namespace Mijalski.GpuStore.Blazor
{
    public class GpuStoreBundleContributor : IBundleContributor
    {
        public void AddScripts(BundleContext context)
        {
        }

        public void AddStyles(BundleContext context)
        {
            context.Add("main.css", true);
        }
    }
}