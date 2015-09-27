using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFDSC.Startup))]
namespace EFDSC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
