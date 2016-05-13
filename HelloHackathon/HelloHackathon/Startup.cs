using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloHackathon.Startup))]
namespace HelloHackathon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
