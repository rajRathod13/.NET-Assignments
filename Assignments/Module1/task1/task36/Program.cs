using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task36
{
    class employee
    {
        int id;
        string name;

        public employee()
        {
            Console.Write("Enter id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter name: ");
            name = Console.ReadLine();

            Console.WriteLine("Employee ID is: " + id);
            Console.WriteLine("Employee name is: " + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            employee obj = new employee();
            Console.Read();
        }
    }
}
