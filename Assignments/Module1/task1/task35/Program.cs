using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task35
{
    class Base
    {
        protected int[] number = new int[10];

        internal void getNumber()
        {
            for(int a = 0; a < number.Length; a++)
            {
                Console.Write("Enter numbers: ");
                number[a] = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
    class Derived : Base
    {
        
        internal void perform()
        {
            int c;
           //int c = number[0];
            getNumber();
            for(int a = 0; a < number.Length; a++)
            {
                for(int b =a+1;b<number.Length;b++)
                {
                    if (number[b] < number[a])
                    {
                        c = number[a];
                        number[a] = number[b];
                        number[b] = c;
                    }
                }
            }
            Console.WriteLine("Elements in asceding order,");

            for(int d = 0; d < number.Length; d++)
            {
                Console.WriteLine(number[d]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Derived obj = new Derived();
            obj.perform();
            Console.Read();
        }
    }
}
