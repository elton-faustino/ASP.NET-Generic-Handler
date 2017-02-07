using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(handler.ui.Startup))]
namespace handler.ui
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
