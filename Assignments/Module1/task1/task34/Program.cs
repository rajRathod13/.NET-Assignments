using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task34
{
    interface cars
    {
        void wheels();
    }
    class audi : cars
    {
        public void wheels()
        {
            Console.WriteLine("Audi has four wheels.");
        }
    }
    class mahindra : cars
    {
        public void wheels()
        {
            Console.WriteLine("Mahindra truck has six wheels.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            audi obj = new audi();
            mahindra obj1 = new mahindra();
            obj.wheels();
            obj1.wheels();
            Console.Read();
        }
    }
}
