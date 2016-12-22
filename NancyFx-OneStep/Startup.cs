using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NancyFx_OneStep.Startup))]
namespace NancyFx_OneStep
{
    public partial class Startup
    {   
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.UseNancy();
        }
    }
}
