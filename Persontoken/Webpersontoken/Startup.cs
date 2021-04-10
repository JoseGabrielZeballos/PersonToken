using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Webpersontoken.Startup))]
namespace Webpersontoken
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
