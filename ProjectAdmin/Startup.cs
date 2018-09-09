using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectAdmin.Startup))]
namespace ProjectAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
