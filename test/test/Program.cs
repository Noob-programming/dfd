using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    
    class Pizza
    {
        public virtual string Tital => $"{nameof(Pizza)}";
        public virtual decimal Price => 10m;

        public override string ToString()
        {
            return $"{Tital} Price {Price}";
        }

    }
    class CheesePizza : Pizza
    {
        public override string Tital => $"{nameof(base.Tital)} {nameof(CheesePizza)}";
        public override decimal Price => base.Price + 5;
    }
    class Chicken : Pizza
    {
        public override string Tital => $"{nameof(base.Tital)} {nameof(Chicken)}";
        public override decimal Price => base.Price + 5;
    }

     

}
