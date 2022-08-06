using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task26
{
    class student
    {
        int roll_no;

        internal void getRollno()
        {
            Console.Write("Enter Roll no: ");
            roll_no = Convert.ToInt32(Console.ReadLine());
        }
    }
    class test : student
    {
        protected int m1, m2;

        internal void getMarks()
        {
            getRollno();
            Console.Write("Enter first subject marks: ");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second subject marks: ");
            m2 = Convert.ToInt32(Console.ReadLine());
        }
    }
    class result : test
    {
        int total;

        internal void myResult()
        {
            getMarks();
            total = m1 + m2;
            Console.WriteLine("Total marks: " + total);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            result r1 = new result();

            r1.myResult();
            Console.Read();
        }
    }
}
