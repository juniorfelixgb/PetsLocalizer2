using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetsLocalizer2.Startup))]
namespace PetsLocalizer2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
