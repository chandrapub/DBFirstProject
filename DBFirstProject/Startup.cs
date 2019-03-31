using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DBFirstProject.Startup))]
namespace DBFirstProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
