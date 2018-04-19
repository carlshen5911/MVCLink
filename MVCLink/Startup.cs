using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCLink.Startup))]
namespace MVCLink
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
