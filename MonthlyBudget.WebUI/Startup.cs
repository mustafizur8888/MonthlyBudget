using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MonthlyBudget.WebUI.Startup))]
namespace MonthlyBudget.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
