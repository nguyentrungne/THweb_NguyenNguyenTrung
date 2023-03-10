using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TH_2080600752_NguyenNguyenTrung.Startup))]
namespace TH_2080600752_NguyenNguyenTrung
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
