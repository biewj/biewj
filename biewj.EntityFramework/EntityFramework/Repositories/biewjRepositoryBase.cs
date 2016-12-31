using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace biewj.EntityFramework.Repositories
{
    public abstract class biewjRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<biewjDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected biewjRepositoryBase(IDbContextProvider<biewjDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class biewjRepositoryBase<TEntity> : biewjRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected biewjRepositoryBase(IDbContextProvider<biewjDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
