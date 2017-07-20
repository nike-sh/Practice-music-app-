using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Practice_application.Startup))]
namespace Practice_application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
