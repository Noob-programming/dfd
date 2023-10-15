using System;

namespace GuidTest
{
	internal abstract class Program
	{
		static void Main(string[] args)
		{
			object i = new object(),
				o = new object();

			Console.WriteLine(i.Equals(o));
		}
	}
}
