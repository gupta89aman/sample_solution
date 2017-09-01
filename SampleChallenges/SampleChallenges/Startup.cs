using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleChallenges.Startup))]
namespace SampleChallenges
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
