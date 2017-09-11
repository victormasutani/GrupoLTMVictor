using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace GrupoLTM.Infrastructure.NHibernate
{
    class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        public static ISession OpenSession()
        {
            return SessionFactory().OpenSession();
        }

        private static ISessionFactory SessionFactory()
        {
            if (_sessionFactory != null)
            {
                return _sessionFactory;
            }

            var config = Fluently.Configure()
                    .Database(MsSqlConfiguration.MsSql2012.ConnectionString(c => c.FromConnectionStringWithKey("connectionStringKey")))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<NHibernateHelper>())
                .BuildSessionFactory();

            return _sessionFactory = config;
        }
    }
}
