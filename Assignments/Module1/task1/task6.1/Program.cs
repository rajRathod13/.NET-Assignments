using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,b,c=0;
            Console.Write("Enter any number: ");
            n = Convert.ToInt32(Console.ReadLine());


            for (int a = 1; a<=n; a++)
            {
                b = a*a;
                c = c + b;
            }
            Console.WriteLine("The total of series is : " + c);
            Console.Read();
        }
    }
}
