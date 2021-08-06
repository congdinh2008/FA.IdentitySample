using Owin;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(FA.IdentitySample.MVCWeb.Startup))]
namespace FA.IdentitySample.MVCWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
