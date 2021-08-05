using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FA.IdentitySample.WebMVC.Startup))]
namespace FA.IdentitySample.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
