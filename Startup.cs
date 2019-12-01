using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CtrlWebT.Startup))]
namespace CtrlWebT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
