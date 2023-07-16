using System;
using System.Diagnostics;

namespace LogicalProgram
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter the input :");
            Console.WriteLine("1.Fibonacci series\n2.PerfectNumber\n3.PrimeNUmber\n4.Reverse a number\n5.coupon Number\n6.Stopwatch\n7.Vending Meachine\n8.Date to day\n9.Temperature conversion" +
                "\n10.Monthly payment");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Fibonnaci.Fib();
                    break;
                case 2:
                    PerfectNumber.IsPerfect();
                    break;
                case 3:
                    PrimeNumber.IsPrime();
                    break;
                case 4:
                    ReverseNumber.Reverse();
                    break;
                case 5:
                    Coupon.GetCoupon();
                    break;
                case 6:
                    StopWatchs.GetTime();
                    break;
                case 7:
                    VendingMachine.GetAmount();
                    break;
                case 8:
                    DayOfDate.GetAmount();
                    break;
                case 9:
                    Temperature.ConvertTemp();
                    break;
                case 10:
                    MonthltPayment.GetAmount();
                    break;


                default:
                    break;

            }
    }
}
