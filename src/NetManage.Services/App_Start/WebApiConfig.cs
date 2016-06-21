using System.Web.Http;
using Owin;
using System.Net.Http.Formatting;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace NetManage.Services
{
    public   static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.Formatters.Add(new JsonMediaTypeFormatter());
            config.Formatters.JsonFormatter.SerializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            }; 

            // Web API routes
            config.MapHttpAttributeRoutes();
          //  config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{id}", new { id = RouteParameter.Optional });            
        }
    }
}