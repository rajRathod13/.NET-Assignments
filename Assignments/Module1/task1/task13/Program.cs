using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13
{
    class myClass
    {
        int a;

        internal void getData()
        {
            Console.Write("Enter value of a: ");
            a = Convert.ToInt32(Console.ReadLine());
        }
        internal void display()
        {
            Console.WriteLine("The value of a is: " + a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass m = new myClass();
            m.getData();
            m.display();
            Console.Read();
        }
    }
}
