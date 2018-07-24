using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SEPApplication3.Startup))]
namespace SEPApplication3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
