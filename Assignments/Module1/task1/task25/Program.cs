using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task25
{
    class person
    {
        string name;
        int age;

        internal void getData()
        {
            Console.Write("Enter name:");
            name = Console.ReadLine();
            Console.Write("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());
        }
    }
    class student : person
    {
        int m1, m2, m3,total;
        int out_of = 300;
        double per;

        internal void calculate()
        {
            getData();
            Console.Write("Enter marks of m1: ");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks of m2: ");
            m2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks of m3: ");
            m3 = Convert.ToInt32(Console.ReadLine());

            total = m1 + m2 + m3;
            Console.WriteLine("Total marks are: " + total);
            per = total * 100 / out_of;

            Console.WriteLine("percentage is: " + per);
            Console.WriteLine();
        }
    }
    class teacher : person
    {
        int salary1,salary2,total_slry;

        internal void total_salary()
        {
            getData();
            Console.Write("Enter salary1: ");
            salary1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter salary2: ");
            salary2 = Convert.ToInt32(Console.ReadLine());
            total_slry = salary1 + salary2;

            Console.WriteLine("Total salary is: " + total_slry);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            teacher t1 = new teacher();
            s1.calculate();
            t1.total_salary();
            Console.Read();
        }
    }
}
