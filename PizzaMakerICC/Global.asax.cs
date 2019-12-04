using System.Web;
using System.Web.Http;

namespace PizzaMakerICC
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
