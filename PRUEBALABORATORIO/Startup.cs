using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PRUEBALABORATORIO.Startup))]
namespace PRUEBALABORATORIO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
