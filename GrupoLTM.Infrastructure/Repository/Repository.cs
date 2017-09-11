using GrupoLTM.Domain.Interfaces;
using GrupoLTM.Infrastructure.NHibernate;
using NHibernate;
using System.Collections.Generic;

namespace GrupoLTM.Infrastructure.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public virtual void Insert(TEntity obj)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                session.Save(obj);
        }

        public virtual TEntity GetById(long id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<TEntity>(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.QueryOver<TEntity>().List();
        }

        public virtual void Update(TEntity obj)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                session.Update(obj);
        }

        public virtual void Delete(TEntity obj)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                session.Delete(obj);
        }
    }
}
