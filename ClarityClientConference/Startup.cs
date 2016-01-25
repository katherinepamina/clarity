using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClarityClientConference.Startup))]
namespace ClarityClientConference
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
