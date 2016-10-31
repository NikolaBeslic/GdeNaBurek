using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GdeNaBurek.Startup))]
namespace GdeNaBurek
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
