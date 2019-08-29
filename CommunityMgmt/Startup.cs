using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CommunityMgmt.Startup))]
namespace CommunityMgmt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
