using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gighubs.Startup))]
namespace Gighubs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
