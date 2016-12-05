using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoogleCharts.Startup))]
namespace GoogleCharts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
