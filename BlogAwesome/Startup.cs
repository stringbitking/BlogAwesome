using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogAwesome.Startup))]
namespace BlogAwesome
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
