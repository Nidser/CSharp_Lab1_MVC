using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab1_MVC.Startup))]
namespace Lab1_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
