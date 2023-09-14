using System;

namespace ConsoleApp2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //var dt = DateTime.Now;
            //var i = int.MinValue;
            //while (i < 0) i++;
            //Console.WriteLine("done");

            //var dt2 = DateTime.Now - dt;
            Guid guid = new Guid();
     
             Console.WriteLine($"{guid}N:16");

            //Console.WriteLine(dt2);
            //Console.ReadKey();
        }
    }
}