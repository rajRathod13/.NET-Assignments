using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task21
{
    class first
    {
         internal int a;

    }
    class second : first
    {
        internal void getData()
        {
            Console.Write("Enter value of a: ");
            a = Convert.ToInt32(Console.ReadLine());
        }
    }
    class third : second
    {
        internal void display()
        {
            getData();
            Console.WriteLine("The value of a  is: " + a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            third obj = new third();
            obj.display();
            Console.Read();
        }
    }
}
