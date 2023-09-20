using System;
using System.Collections.Generic;

namespace Solid
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public abstract void Print();
    }

    public class Enginer : Person
    {
        public List<string> Tool { get; set; }
        /// <inheritdoc />
        public override void Print()
        {
            Console.WriteLine($"Name {Name}, Age {Age} Salary {Salary}");
            Console.WriteLine($"Job title {nameof(Enginer)}");
            foreach (var tool in Tool)
            {
                Console.WriteLine($" {tool}");
            }
        }
    }

    public class Doctor : Person
    {
        public string Specialization { get; set; }
        /// <inheritdoc />
        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age} Salary: {Salary}");
            Console.WriteLine($"Specialization {Specialization}");
        }
    }


    public class Teacher : Person
    {
        public string Specialization { get; set; }
        public string ClassSenter { get; set; }
        /// <inheritdoc />
        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age} Salary: {Salary}");
            Console.WriteLine($"Specialization: {Specialization}\t Class :{ClassSenter}");
        }
    }

}