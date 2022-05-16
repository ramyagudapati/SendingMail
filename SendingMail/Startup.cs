using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SendingMail.Startup))]
namespace SendingMail
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
