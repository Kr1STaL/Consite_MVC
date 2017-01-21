using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Consite_iTransition.Startup))]
namespace Consite_iTransition
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
