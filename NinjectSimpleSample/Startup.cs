using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NinjectSimpleSample.Startup))]
namespace NinjectSimpleSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
