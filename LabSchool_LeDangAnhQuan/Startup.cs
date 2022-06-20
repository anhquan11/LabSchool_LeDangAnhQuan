using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LabSchool_LeDangAnhQuan.Startup))]
namespace LabSchool_LeDangAnhQuan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
