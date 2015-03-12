using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gestor_Laboratorios.Startup))]
namespace Gestor_Laboratorios
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
