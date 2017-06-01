using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestAppForSOLIDAndDesignPatterns.Startup))]
namespace TestAppForSOLIDAndDesignPatterns
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
