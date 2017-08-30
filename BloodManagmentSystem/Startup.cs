using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BloodManagmentSystem.Startup))]
namespace BloodManagmentSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
