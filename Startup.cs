using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Alacrity.PostgresMembership.Startup))]
namespace Alacrity.PostgresMembership
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
