using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,b = 0;
            Console.Write("Enter any number: ");
            n = Convert.ToInt32(Console.ReadLine());

            for( int a = 1; a<= n; a++)
            {
                b = (b + (a * a));
            }
            Console.WriteLine("The series sum is:" + b);
            Console.Read();
        }
    }
}
