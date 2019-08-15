using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vod.Startup))]
namespace Vod
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
