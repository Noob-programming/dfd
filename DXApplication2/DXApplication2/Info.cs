using System;
using System.Collections.Generic;

namespace DXApplication2
{
	public static class Genreator
	{
		private static readonly Random random = new Random();

		public static Guid GenerateRandomGuid() => Guid.NewGuid();

		public static string GenerateRandomGender()
		{
			string[] gender = { "Male", "Female" };
			return gender[random.Next(gender.Length)];
		}
		public static string GenerateRandomName()
		{
			var names = new List<string>
			{
				"Alice Smith",
				"Bob Johnson",
				"Charlie Brown",
				"David Davis",
				"Emma Lee",
				"Frank Wilson",
				"Grace Clark",
				"Hannah Hall",
				"Ivy Lopez",
				"Jack Young",
				"Kate Walker",
				"Liam Lewis",
				"Mia Martin",
				"Noah Adams",
				"Olivia Harris",
				"Sophia Perez",
				"Thomas King",
				"Violet Wright",
				"William White",
				"Zoe Turner"
			};
			return names[random.Next(names.Count)];
		}

		public static int GenerateRandomAge() => random.Next(18, 65);

	}

	public static class Repostory
	{
		static int count = 0;

		public static List<Employees> Load()
		{
			List<Employees> employees = new List<Employees>();

			for (int i = 0; i < 1000; i++)
			{
				employees.Add(new Employees
				{
					EmGuid = Genreator.GenerateRandomGuid(),
					EmployeeId = ++count,
					Name = Genreator.GenerateRandomName(),
					Age = Genreator.GenerateRandomAge(),
					Gender = Genreator.GenerateRandomGender()
				});
			}

			return employees;
		}

	}
}