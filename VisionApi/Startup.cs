using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VisionApi.Startup))]
namespace VisionApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
