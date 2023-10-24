using System;
using System.Collections.Generic;
using RepoPattern.Repository.Base;

namespace RepoPattern.Repository
{
	public class MainRepo<T> : IRepository<T> where T : class
	{
		/// <inheritdoc />
		public T GetByGuid(Guid guid)
		{
			throw new NotImplementedException();
		}

		/// <inheritdoc />
		public IEnumerable<T> GetAll()
		{
			throw new NotImplementedException();
		}
	}
}