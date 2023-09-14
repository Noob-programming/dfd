using System;
using System.Collections.Generic;

namespace Composition_OVER_Inheritance_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /********/
            var pizza = new Pizza();
            pizza.toppings.Add(new Cheese());
            pizza.toppings.Add(new Pepperoni());
            pizza.toppings.Add(new chicken());
            Console.WriteLine(pizza);
            Console.ReadKey();
        }
    }

    class Pizza
    {
        public virtual decimal Price => 10m;

        public override string ToString()
        {

            var output = $"{nameof(Pizza)}";

            output += $" Price {Price:C}";
            foreach (var item in toppings)
            {
                output += $"{item.Title}";
            }
            return $"{output} {Calculate()}";

        }
        public List<ITopping> toppings
        {
            get;
             set;
        } = new List<ITopping>();

        void AddTopping(ITopping topping)
            =>
                toppings.Add(topping);
        private decimal Calculate()
        {
            decimal result = Price;
            foreach (var topping in toppings)
            {
                result += topping.Price;
            }
            return result;
        }
    }

    interface ITopping
    {
        string Title { get; }
        decimal Price { get; }
    }


    class Cheese : ITopping
    {
        public string Title => nameof(Cheese);
        public decimal Price => 5m;
    }
    class Pepperoni : ITopping
    {
        public string Title => nameof(Pepperoni);
        public decimal Price => 7m;
    }

    class chicken : ITopping
    {
        public string Title => nameof(chicken);
        public decimal Price => 10m;
    }
    class blackpepper : ITopping
    {
        public string Title => nameof(blackpepper);
        public decimal Price => 5m;

    }

    class greenpaper : ITopping
    {
        public string Title => nameof(greenpaper);
        public decimal Price => 7m;
    }

}
