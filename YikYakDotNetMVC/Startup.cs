using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YikYakDotNetMVC.Startup))]
namespace YikYakDotNetMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
