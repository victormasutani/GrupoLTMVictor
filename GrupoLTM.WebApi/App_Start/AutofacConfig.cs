using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using GrupoLTM.Application.Services;
using GrupoLTM.Application.Interfaces;
using GrupoLTM.Infrastructure.Repository;
using GrupoLTM.Domain.Interfaces;

namespace GrupoLTM.WebApi.App_Start
{
    /// <summary>
    /// Represent Autofac configuration.
    /// </summary>
    public static class AutofacConfig
    {
        /// <summary>
        /// Configured instance of <see cref="IContainer"/>
        /// <remarks><see cref="AutofacConfig.Configure"/> must be called before trying to get Container instance.</remarks>
        /// </summary>
        public static IContainer Container;

        /// <summary>
        /// Initializes and configures instance of <see cref="IContainer"/>.
        /// </summary>
        /// <param name="configuration"></param>
        public static void Configure(HttpConfiguration configuration)
        {
            var builder = new ContainerBuilder();

            // Other components can be registered here.

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();

            Container = builder.Build();

            configuration.DependencyResolver = new AutofacWebApiDependencyResolver(Container);
        }
    }
}