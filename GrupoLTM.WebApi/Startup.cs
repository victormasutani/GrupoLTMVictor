using GrupoLTM.Application.AutoMapper;
using GrupoLTM.WebApi.App_Start;
using Microsoft.Owin;
using Owin;
using System.Configuration;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

[assembly: OwinStartup(typeof(GrupoLTM.WebApi.Startup))]
namespace GrupoLTM.WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var configuration = new HttpConfiguration();

            CorsConfig.ConfigureCors(ConfigurationManager.AppSettings["cors"]);
            app.UseCors(CorsConfig.Options);

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            FormatterConfig.Configure(configuration);
            AutofacConfig.Configure(configuration);
            app.UseAutofacMiddleware(AutofacConfig.Container);
            SwaggerConfig.Configure(configuration);

            app.UseWebApi(configuration);

            AutoMapperConfig.InitializeAutoMapper();

            ConfigureAuth(app);
        }
    }
}
