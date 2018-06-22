using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security.Cookies;


[assembly: OwinStartup(typeof(AutenticacaoAspNetMvc.Startup1))]

namespace AutenticacaoAspNetMvc
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {

                AuthenticationType = "ApplicationCookie",
                LoginPath = new PathString("/Autenticacao/Login/")


        });
        }
    }
}
