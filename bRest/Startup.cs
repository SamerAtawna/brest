using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bRest.Startup))]
namespace bRest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
