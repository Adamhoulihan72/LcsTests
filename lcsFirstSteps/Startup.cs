using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lcsFirstSteps.Startup))]
namespace lcsFirstSteps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
