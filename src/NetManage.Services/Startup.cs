
using Owin;

namespace NetManage.Services
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Owin pipeline configuration
            ConfigureAuth(app);
        }
    }
}