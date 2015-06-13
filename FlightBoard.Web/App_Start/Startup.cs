
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Owin;

namespace FlightBoard.Web
{
    public class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            IAppBuilder iappBuilder = app;
            CookieAuthenticationOptions authenticationOptions1 = new CookieAuthenticationOptions();
         //   ((AuthenticationOptions)authenticationOptions1).set_AuthenticationType("ApplicationCookie");
        //    authenticationOptions1.set_LoginPath(new PathString("/Account/Login"));
            CookieAuthenticationOptions authenticationOptions2 = authenticationOptions1;
            CookieAuthenticationExtensions.UseCookieAuthentication(iappBuilder, authenticationOptions2);
            AppBuilderExtensions.UseExternalSignInCookie(app, "ExternalCookie");
        }

        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}
