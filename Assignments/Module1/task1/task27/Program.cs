using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task27
{
    class MyClass
    {
        public int a;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass One = new MyClass();

            Console.Write("Enter value of a: ");
            One.a = Convert.ToInt32(Console.ReadLine());
            int A = One.a;
            Console.WriteLine("The value of A is: " + A);
            Console.Read();
        }
    }
}
