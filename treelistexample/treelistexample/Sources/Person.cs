using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treelistexample.Sources
{
	internal class Person
	{
		public Guid Guid { get; set; } = Guid.NewGuid();
		public int ID { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }

		public Person()
		{

		}
	}
}
