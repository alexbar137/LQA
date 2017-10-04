using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LQA.Startup))]
namespace LQA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
