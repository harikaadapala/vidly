using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vidly_3.Startup))]
namespace vidly_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
