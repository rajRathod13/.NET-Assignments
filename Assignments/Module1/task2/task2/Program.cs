using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //explicite conversion
            int a = 20;
            string b = Convert.ToString(a);

            Console.WriteLine("Now b is String and it's value is : '{0}'",b);

            //Implicite conversion
            int c = 10;

            Console.WriteLine("Number is :" + c);
            Console.Read();

        }
    }
}
