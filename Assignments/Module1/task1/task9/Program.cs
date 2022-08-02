using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{   
    class student
    {
        int m1, m2, m3,sum;
        float avg;

        internal void getMarks()
        {
            Console.Write("Enter marks of m1:");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks of m2:");
            m2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks of m3:");
            m3 = Convert.ToInt32(Console.ReadLine());
        }
        internal void Sum()
        {
            sum = m1 + m2 + m3;
            Console.WriteLine("The sum of three marks is: " + sum);

        }
        internal void Average()
        {
            avg = (m1 + m2 + m3) / 3;
            Console.WriteLine("The average of three marks is: " + avg);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            student student1 = new student();

            student1.getMarks();
            student1.Sum();
            student1.Average();

            Console.Read();
        }
    }
}
