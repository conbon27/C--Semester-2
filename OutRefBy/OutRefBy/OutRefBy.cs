using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutRefBy
{
    public class Exercise
    {
        void GetDeposit(ref decimal amount)
        {
            amount = 450.50M;

            Console.WriteLine("In GetDeposit()");
            Console.Write("Amount: $");
            Console.WriteLine(amount);
        }
        
        void GetWithdrawal(out decimal amount)
        {
            amount = 265.40M;

            Console.WriteLine("In GetWidrawal()");
            Console.Write("Amount: $");
            Console.WriteLine(amount);
        }
        static int Main(string[] args)
        {
            decimal depositAmount = 0M;
            decimal withdrawalAmount = 0M;
            var exo = new Exercise();

            Console.WriteLine("In Main()");
            Console.Write("Amount: $");
            Console.WriteLine(depositAmount);

            Console.WriteLine("=============");
            exo.GetDeposit(ref depositAmount);
            Console.WriteLine("=============");

            Console.WriteLine("Bank in Main()");
            Console.Write("Amount: $");
            Console.WriteLine(depositAmount);

            Console.WriteLine("============");
            exo.GetWithdrawal(out withdrawalAmount);
            Console.WriteLine("============");

            Console.WriteLine("Bank in Main()");
            Console.Write("Amount: $");
            Console.WriteLine(withdrawalAmount);

            return 0;
        }
    }
}
