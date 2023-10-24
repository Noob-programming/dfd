using System;
using System.Collections.Generic;

namespace RepoPattern.Repository.Base
{
	public interface IRepository<T> where T : class
	{
		T GetByGuid(Guid guid);

		IEnumerable<T> GetAll();

	}
}