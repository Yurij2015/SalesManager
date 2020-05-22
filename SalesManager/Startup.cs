using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SalesManager.Startup))]
namespace SalesManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
