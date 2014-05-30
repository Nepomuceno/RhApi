using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RhApi.Startup))]
namespace RhApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
