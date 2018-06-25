using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Unico.Startup))]
namespace Unico
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
