using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdventureTime.Startup))]
namespace AdventureTime
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
