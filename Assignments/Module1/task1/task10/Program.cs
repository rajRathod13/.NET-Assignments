using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10
{
    class Factorial
    {
         int n,a, fact = 1;
        
        internal void getFactorial()
        {
            Console.Write("Enter value of n:");
            n = Convert.ToInt32(Console.ReadLine());

            for(a = 1; a <= n; a++)
            {
                fact = fact * a;
            }
            Console.WriteLine("The factorial of n is:"+ fact);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {

            Factorial f = new Factorial();

            f.getFactorial();
            Console.Read();
        }
    }
}
