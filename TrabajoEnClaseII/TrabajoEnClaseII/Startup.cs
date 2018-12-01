using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrabajoEnClaseII.Startup))]
namespace TrabajoEnClaseII
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
