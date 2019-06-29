using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NumberToNumberName.Startup))]
namespace NumberToNumberName
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
