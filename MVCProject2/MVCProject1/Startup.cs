using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCProject1.Startup))]
namespace MVCProject1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
