using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TruongMinhHuu_2080600088.Startup))]
namespace TruongMinhHuu_2080600088
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
