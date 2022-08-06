using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Generics allow you to define the specification of the data type of programming elements in a class or a method,
//until it is actually used in the program. 
namespace task39
{
    class Myclass<Type1, Type2>
    {
        Type1 id;
        Type2 name;

        public Myclass(Type1 i, Type2 n)
        {

            id = i;
            name = n;
        }

        public void display()
        {
            Console.WriteLine("Id is: " + id);
            Console.WriteLine("Name is: " + name);
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Myclass<int, string> obj = new Myclass<int, string>(120, "Raj");
            obj.display();
            Console.Read();
        }
    }
}
