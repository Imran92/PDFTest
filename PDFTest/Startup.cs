using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PDFTest.Startup))]
namespace PDFTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
