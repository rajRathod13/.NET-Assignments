using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task29
{
    class account
    {
        int account_no;
        string name;

        internal void getCustomerData()
        {
            Console.Write("Enter Account no: ");
            account_no = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Account holder name: ");
            name = Console.ReadLine();
            Console.WriteLine();
        }
    }
    class saving_account : account
    {
        int num,  awailable_balance,witnhdraw_amount;
        int total_balance = 100000;  //Assume
        double SI, P, R, N;

        internal void Saving_service()
           
        {
            getCustomerData();
            Console.WriteLine("Press 1 for Simple Interest");
            Console.WriteLine("Press 2 for withdraw");
            Console.WriteLine("Press 3 for Cheque book");
            Console.Write("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (num)
            {
                case 1:
                    Console.Write("Enter principle value: ");
                    P = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter rate of interest: ");
                    R = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter no of years: ");
                    N = Convert.ToDouble(Console.ReadLine());

                    SI = P * R * N / 100;
                    Console.Write("The simple interest is: " + SI);
                    break;

                case 2:
                    Console.WriteLine("Total balance is: " + total_balance);
                    Console.Write("Enter amount to be withdrawn: ");
                    witnhdraw_amount = Convert.ToInt32(Console.ReadLine());

                    awailable_balance = total_balance - witnhdraw_amount;

                    total_balance = awailable_balance;
                    Console.WriteLine("Available balance is: " + total_balance);
                    break;

                case 3:
                    Console.WriteLine("For cheque book service please open Current acocunt.");
                    break;

                default:
                    Console.WriteLine("Sorry! you havent choose any service.");
                    break;

            }
        }
    }
    class current_account : account
    {
        int num, withdraw_amount,available_balance;
        int total_balance = 10000;
        int min_balance = 2000;
        int chequeBook = 200;
        internal void Current_service()
        {
            getCustomerData();
            Console.WriteLine("Press 1 for withdraw");
            Console.WriteLine("Press 2 for Cheque book");
            Console.Write("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Total balance is: " + total_balance);
                    Console.WriteLine("If after withdrawal account balance less than minimum balance then need to pay penalty Rs.200");
                    Console.Write("Enter amount to be withdraw: ");
                    withdraw_amount = Convert.ToInt32(Console.ReadLine());
                    if(withdraw_amount < total_balance)
                    {
                        available_balance = total_balance - withdraw_amount;
                        if(available_balance < min_balance)
                        {
                            Console.WriteLine("Account balance less than minimum amount, So need to pay standard penalty Rs.200.");
                            available_balance = total_balance - 200;
                            Console.WriteLine("Penalty deducted and Available balance is: " + available_balance);
                        }
                        else
                        {
                            total_balance = available_balance;
                            Console.WriteLine("Available balance is: "+ total_balance);
                        }
                    }else
                    {
                        Console.WriteLine("Sorry! you don't have required balance in account.");
                    }
                    break;

                case 2:
                    available_balance = total_balance - chequeBook;
                    Console.WriteLine("Available balance is: " + available_balance);
                    Console.WriteLine("Cheque book issued on: " + DateTime.Now);
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            saving_account SA1 = new saving_account();
            current_account CA1 = new current_account();
             string account_type;

        Console.WriteLine("Enter saving for Saving account services");
            Console.WriteLine("Enter current for Current account services");
            Console.Write("Enter type of account: ");
            account_type = Console.ReadLine();

            switch (account_type)
            {
                case "saving":
                    SA1.Saving_service();
                    break;

                case "current":
                    CA1.Current_service();
                    break;

                default:
                    Console.WriteLine("You haven't selected any service, Please press any number.");
                    break;
            }
            Console.Read();
        }
    }
}
