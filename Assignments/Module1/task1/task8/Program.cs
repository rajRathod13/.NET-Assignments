using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class BaseClass
    {
        int a;

        internal void getData()
        {
            Console.Write("Enter value of a: ");
            a = Convert.ToInt32(Console.ReadLine());
        }
        internal void display()
        {
            Console.WriteLine("The value of a is: "+ a);
        }
    }
    class childClass : BaseClass
    {
        internal void showData()
        {
            getData();
            display();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            childClass obj = new childClass();
            obj.showData();
            Console.Read();
        }
    }
}
