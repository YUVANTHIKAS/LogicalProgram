using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class DayOfDate
    {
        internal static void GetAmount()
        {
            int[] amount = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            Console.WriteLine("Enter the amount ");
            int input = Convert.ToInt32(Console.ReadLine());
            int temp = input;
            int noteCount = 0;
            foreach (var balanceamount in amount)
            {
                noteCount += (temp / balanceamount);
                temp %= balanceamount;
            }
            Console.WriteLine(noteCount);
        }
    }
}
