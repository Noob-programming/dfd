using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> number = new List<int> { 1, 1, 2, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

			Console.WriteLine(number);

			var res = number.Select(x => x)
				.Distinct();
			foreach (var re in res)
			{
				Console.WriteLine(re);
			}

			Console.ReadLine();

		}
	}
}
