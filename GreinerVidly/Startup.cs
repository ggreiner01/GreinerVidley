using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GreinerVidly.Startup))]
namespace GreinerVidly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
