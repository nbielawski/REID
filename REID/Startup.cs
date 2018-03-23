using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(REID.Startup))]
namespace REID
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
