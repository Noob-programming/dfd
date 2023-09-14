using System;
using System.Collections.Generic;

namespace Solid
{
    internal class Program
    {
        private static void Main()
        {
            Enginer enginer = new Enginer
            {
                Age = 23,
                Name = "sam",
                Tool = new List<string> { "autocad", "hammer", "drile", "pen", "pensale" },
                Salary = 2000m
            };
            enginer.Print();
            Console.WriteLine();
            Teacher teacher = new Teacher
            {
                Age = 23,
                Name = "sam",
                Specialization = "English",
                Salary = 2000m,
                ClassSenter = "C2"
            };
            teacher.Print();
        }
    }

    internal class Account
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public string Email { get; set; }

        public Account(string name, decimal balance, string email)
        {
            Name = name;
            Balance = balance;
            Email = email;
        }
    }

    internal class MakeTran
    {


        public void MakeTranstion(Account account
            , decimal amount)
        {

        }
    }

    internal class EmailMessage
    {
        public void Send(Account account, string message, DateTime dateTime)
        {

        }
    }
}
