using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Scouting.Startup))]
namespace Scouting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
