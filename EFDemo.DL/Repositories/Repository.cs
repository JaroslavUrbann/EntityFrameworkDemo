using System.Collections.Generic;

namespace EFDemo.DL.Repositories
{
	internal class Repository<TEntity> : IRepository<TEntity> where TEntity : class
	{
		protected readonly EntitiesContext Context;

		public Repository(EntitiesContext context)
		{
			Context = context;
		}

		public void Add(TEntity entity)
		{
			Context.Set<TEntity>().Add(entity);
		}

		public void AddRange(IEnumerable<TEntity> entities)
		{
			Context.Set<TEntity>().AddRange(entities);
		}

		public IEnumerable<TEntity> GetAll()
		{
			return Context.Set<TEntity>();
		}

		public TEntity GetById(int id)
		{
			return Context.Set<TEntity>().Find(id);
		}

		public void Remove(TEntity entity)
		{
			Context.Set<TEntity>().Remove(entity);
		}

		public void RemoveRange(IEnumerable<TEntity> entities)
		{
			Context.Set<TEntity>().RemoveRange(entities);
		}
	}
}
