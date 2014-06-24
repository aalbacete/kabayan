using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kabayan.Startup))]
namespace Kabayan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
