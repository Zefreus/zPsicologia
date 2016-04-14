using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(zefPsicologia.Startup))]
namespace zefPsicologia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
