using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuirckyBookRental.Startup))]
namespace QuirckyBookRental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
