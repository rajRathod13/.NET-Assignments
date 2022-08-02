using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task18
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "This is myString";

            Console.WriteLine(a.Replace('h', 'H'));
            Console.WriteLine("Sring value replace: " + a.Replace("is", "IS"));
            Console.Read();
        }
    }
}
