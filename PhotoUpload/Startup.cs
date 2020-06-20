using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhotoUpload.Startup))]
namespace PhotoUpload
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
