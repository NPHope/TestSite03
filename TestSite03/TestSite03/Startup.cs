using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestSite03.Startup))]
namespace TestSite03
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
