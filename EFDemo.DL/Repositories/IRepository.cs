﻿using System.Collections.Generic;

namespace EFDemo.DL.Repositories
{
	public interface IRepository<TEntity> where TEntity : class
	{
		void Add(TEntity entity);

		void AddRange(IEnumerable<TEntity> entities);

		void Remove(TEntity entity);

		void RemoveRange(IEnumerable<TEntity> entities);

		TEntity GetById(int id);

		IEnumerable<TEntity> GetAll();
	}
}