using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,c = 1;
            Console.Write("Enter any number:");
            n = Convert.ToInt32(Console.ReadLine());

            for(int a = 1; a <= n; a++)
            {
                for(int b = 1; b <= a; b++)
                {
                    
                    Console.Write(c);
                    c++;
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
