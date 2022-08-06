using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task37
{
    class header
    {
        internal string[] pro_name = {"MI note5","MI note5Pro","MI note6","MI nonte6Pro","MI nonte9","MI note9Pro","MI note10","MI note10Pro","iPhone10","iPhone13"};
         internal int[] pro_price = {12000,13000,14000,15000,16000,17000,18000,19000,21000,22000};

        internal void getHeader()
        {
            Console.WriteLine("Sr No.   " + "Product_name   "+ "Product_Price");
            for(int a = 0; a<pro_name.Length; a++)
            {
                int b = a + 1;
                Console.WriteLine("0"+b + "       " + pro_name[a] + "       " + pro_price[a]);
            }
        }
    }
    class customer : header
    {
        int num,qty,total;
        
        internal void select()
        {
            for (int b = 1; b <= pro_name.Length; b++)
            {
                Console.WriteLine("Press {0} for product{1}", b, b);
            }
            Console.WriteLine();


            Console.Write("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.Write("Enter Qty for purchase: ");
                    qty = Convert.ToInt32(Console.ReadLine());
                    total = qty * pro_price[0];
                    Console.WriteLine("Total amount to be paid is: " + total);
                    break;

                case 2:
                    Console.Write("Enter Qty for purchase: ");
                    qty = Convert.ToInt32(Console.ReadLine());
                    total = qty * pro_price[1];
                    Console.WriteLine("Total amount to be paid is: " + total);
                    break;

                case 3:
                    Console.Write("Enter Qty for purchase: ");
                    qty = Convert.ToInt32(Console.ReadLine());
                    total = qty * pro_price[2];
                    Console.WriteLine("Total amount to be paid is: " + total);
                    break;

                case 4:
                    Console.Write("Enter Qty for purchase: ");
                    qty = Convert.ToInt32(Console.ReadLine());
                    total = qty * pro_price[3];
                    Console.WriteLine("Total amount to be paid is: " + total);
                    break;

                case 5:
                    Console.Write("Enter Qty for purchase: ");
                    qty = Convert.ToInt32(Console.ReadLine());
                    total = qty * pro_price[4];
                    Console.WriteLine("Total amount to be paid is: " + total);
                    break;

                case 6:
                    Console.Write("Enter Qty for purchase: ");
                    qty = Convert.ToInt32(Console.ReadLine());
                    total = qty * pro_price[5];
                    Console.WriteLine("Total amount to be paid is: " + total);
                    break;

                case 7:
                    Console.Write("Enter Qty for purchase: ");
                    qty = Convert.ToInt32(Console.ReadLine());
                    total = qty * pro_price[6];
                    Console.WriteLine("Total amount to be paid is: " + total);
                    break;

                case 8:
                    Console.Write("Enter Qty for purchase: ");
                    qty = Convert.ToInt32(Console.ReadLine());
                    total = qty * pro_price[7];
                    Console.WriteLine("Total amount to be paid is: " + total);
                    break;

                case 9:
                    Console.Write("Enter Qty for purchase: ");
                    qty = Convert.ToInt32(Console.ReadLine());
                    total = qty * pro_price[8];
                    Console.WriteLine("Total amount to be paid is: " + total);
                    break;

                case 10:
                    Console.Write("Enter Qty for purchase: ");
                    qty = Convert.ToInt32(Console.ReadLine());
                    total = qty * pro_price[9];
                    Console.WriteLine("Total amount to be paid is: " + total);
                    break;

                default:
                    Console.WriteLine("Please select valid number");
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            header obj = new header();
            customer obj1 = new customer();
            obj.getHeader();
            obj1.select();
            Console.Read();
        }
    }
}
