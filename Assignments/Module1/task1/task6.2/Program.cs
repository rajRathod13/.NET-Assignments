using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,b = 1;
            Console.Write("Enter any number: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int a=0; a <= n; a++)
            {
                b = a + b;
            }
            Console.WriteLine(b);
            Console.Read();
        }
    }
}
