using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DesafioHappe.Startup))]
namespace DesafioHappe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
