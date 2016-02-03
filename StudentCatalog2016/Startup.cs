using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentCatalog2016.Startup))]
namespace StudentCatalog2016
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
