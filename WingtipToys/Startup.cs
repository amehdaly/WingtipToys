using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WingtipToys.Startup))]
namespace WingtipToys
{
    //ToDo :
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
