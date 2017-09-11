using Autofac;
using Autofac.Integration.Owin;
using GrupoLTM.Application.Interfaces;
using GrupoLTM.WebApi.Providers;
using System.Collections.Generic;
using System.Web;
using System.Web.Http;

namespace GrupoLTM.WebApi.Controllers
{
    [RoutePrefix("product")]
    public class ProductController : ApiController
    {
        [HttpGet, Route("list")]
        [Authorize]
        public IHttpActionResult List()
        {
            var autofacLifetimeScope = OwinContextExtensions.GetAutofacLifetimeScope(HttpContext.Current.GetOwinContext());
            var productService = autofacLifetimeScope.Resolve<IProductService>();

            return Ok(productService.GetProducts());
        }
    }
}
