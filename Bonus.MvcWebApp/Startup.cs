using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bonus.MvcWebApp.Startup))]
namespace Bonus.MvcWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
