using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    class operations
    {
        int a, b, add, sub, multi;
        float div;

        public operations(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        internal void sum()
        {
            add = a + b;
        }
        internal void Sub()
        {
            sub = a - b;
        }
        internal void Multi()
        {
            multi = a * b;
        }
        internal void Div()
        {
            div = a / b;
        }
        internal void display()
        {
            Console.WriteLine("The addition is:" + add);
            Console.WriteLine("The substraction is: " + sub);
            Console.WriteLine("The multiplication is: " + multi);
            Console.WriteLine("The division is: " + div);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
                operations obj = new operations(10, 2);

                obj.sum();
                obj.Sub();
                obj.Multi();
                obj.Div();
                obj.display();
                Console.Read();
        }
    }
}
