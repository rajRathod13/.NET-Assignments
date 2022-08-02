using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter any number : ");
            n = Convert.ToInt32(Console.ReadLine());

            for(int a = 1; a <= n; a++)
            {
                for ( int b = 1; b <= a; b++)
                {
                    if(b%2 == 0)
                    {
                        Console.Write("# ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
