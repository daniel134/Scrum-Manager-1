using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Scrum_Manager.Startup))]
namespace Scrum_Manager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
