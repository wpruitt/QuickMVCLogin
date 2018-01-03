using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuickMVCLogin.Startup))]
namespace QuickMVCLogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
