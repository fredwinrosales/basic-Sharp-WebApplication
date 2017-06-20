using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(basic_Sharp_WebApplication.Startup))]
namespace basic_Sharp_WebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
