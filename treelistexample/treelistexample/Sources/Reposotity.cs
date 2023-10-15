using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treelistexample.Sources
{
	public static class Reposotity
	{
		public static class Source
		{
			static Random r = new Random();
			public static Guid RandomGuid => Guid.NewGuid();

			public static int RandomInt => r.Next(1, 1000);


		}

		public static Person LoadData() => null;
	}
}
