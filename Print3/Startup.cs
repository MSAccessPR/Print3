using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Print3.Startup))]
namespace Print3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
