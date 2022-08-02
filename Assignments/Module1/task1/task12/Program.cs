using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task12
{
    class shape
    {
        internal void area(double a)
        {
            Console.WriteLine("Area of circle is: {0}", 3.14 * a * a);
        }
        internal  void area(int l , int b)
        {
            Console.WriteLine("Area of rectangle is: {0}", l * b);
        }
        internal void area(double c, double h)
        {
            Console.WriteLine("Area of trialngle is: {0}", (0.5) * c * h);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            shape obj = new shape();
            obj.area(5.5);
            obj.area(5, 3);
            obj.area(6.3, 3.3);
            Console.Read();
        }
    }
}
