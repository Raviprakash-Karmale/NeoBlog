using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NeoBlog.Web.Startup))]
namespace NeoBlog.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
