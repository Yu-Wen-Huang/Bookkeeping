using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookkeepingHW.Startup))]
namespace BookkeepingHW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
