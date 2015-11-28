using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Final_Project_MVC.Startup))]
namespace Final_Project_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
