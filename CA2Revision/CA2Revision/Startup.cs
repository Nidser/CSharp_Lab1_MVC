using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CA2Revision.Startup))]
namespace CA2Revision
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
