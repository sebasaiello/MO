using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MO.Startup))]
namespace MO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
