using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DuyguBlog.Startup))]
namespace DuyguBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
