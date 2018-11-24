using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FilterSamples.Startup))]
namespace FilterSamples
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
