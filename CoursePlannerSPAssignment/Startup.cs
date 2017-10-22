using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoursePlannerSPAssignment.Startup))]
namespace CoursePlannerSPAssignment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
