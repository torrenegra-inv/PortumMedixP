using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PortumMedixP.Startup))]
namespace PortumMedixP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
