using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleToDo.Startup))]
namespace SampleToDo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
