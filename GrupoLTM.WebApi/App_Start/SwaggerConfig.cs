using Swashbuckle.Application;
using System.Web.Http;

namespace GrupoLTM.WebApi
{
    public class SwaggerConfig
    {
        public static void Configure(HttpConfiguration configuration)
        {
            configuration.EnableSwagger(c => c.SingleApiVersion("v1", "GrupoLTM WebAPI Victor")).EnableSwaggerUi();
        }
    }
}