using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyBookstore.Startup))]
namespace MyBookstore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
