using Owin;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(FA.IdentitySample.WebMVCWithNuget.Startup))]
namespace FA.IdentitySample.WebMVCWithNuget
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
