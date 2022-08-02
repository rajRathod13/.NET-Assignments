using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task22
{
    class details
    {
        internal string[] name = new string[10];
        internal string[] department = new string[10];
        internal int[] salary = new int[10];
        internal int[] index = { 1,2,3,4,5,6,7,8,9,10};

        internal void getDetails()
        {
            for (int a = 0; a < salary.Length; a++)
            {
                Console.Write("Name of employee "+index[a]+": " + name[a]);
                name[a] = Console.ReadLine();
                Console.Write("Slalary:  ", salary[a]);
                salary[a] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Name of department: ", department[a]);
                department[a] = Console.ReadLine();
                Console.WriteLine();
            }
        }

        internal void display()
        { int max_num = salary[0];
            for(int b = 0;b < salary.Length; b++)
            {
                if (salary[b] > max_num)
                {
                    Console.WriteLine("The highest salary paid employee is,");
                    Console.WriteLine("Employee Name:" + name[b]);
                    Console.WriteLine("Employee Department: " + department[b]);
                }
            }
        }
}
    class Program
    {
        static void Main(string[] args)
        {
            details obj = new details();

            obj.getDetails();
            obj.display();
            Console.Read(); 
        }
    }
}
