using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HawkTest.Startup))]
namespace HawkTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
