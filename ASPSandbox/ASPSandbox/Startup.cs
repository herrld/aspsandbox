using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPSandbox.Startup))]
namespace ASPSandbox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
