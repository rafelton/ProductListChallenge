using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductListChallenge.Startup))]
namespace ProductListChallenge
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
