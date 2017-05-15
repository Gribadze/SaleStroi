using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SaleStroy.Startup))]
namespace SaleStroy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
