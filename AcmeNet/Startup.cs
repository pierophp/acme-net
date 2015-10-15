using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AcmeNet.Startup))]
namespace AcmeNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
