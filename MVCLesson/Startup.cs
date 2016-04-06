using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCLesson.Startup))]
namespace MVCLesson
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
