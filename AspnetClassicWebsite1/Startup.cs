using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspnetClassicWebsite1.Startup))]
namespace AspnetClassicWebsite1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
