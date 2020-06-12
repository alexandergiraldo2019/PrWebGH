using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrWebGH.Startup))]
namespace PrWebGH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
