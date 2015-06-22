using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyExampleWebApps.Startup))]
namespace MyExampleWebApps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
