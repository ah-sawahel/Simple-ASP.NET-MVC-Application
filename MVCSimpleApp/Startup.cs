using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCSimpleApp.Startup))]
namespace MVCSimpleApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
