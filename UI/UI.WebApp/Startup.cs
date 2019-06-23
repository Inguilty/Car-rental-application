using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UI.WebApp.Startup))]
namespace UI.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
