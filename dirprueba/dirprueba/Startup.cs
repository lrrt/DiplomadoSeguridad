using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dirprueba.Startup))]
namespace dirprueba
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
