using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mk_woods.Startup))]
namespace mk_woods
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
