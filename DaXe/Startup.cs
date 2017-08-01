using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DaXe.Startup))]
namespace DaXe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
