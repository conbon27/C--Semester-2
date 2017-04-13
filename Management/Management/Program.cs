using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByRef
{
    public class Management
    {
        public void ShowAccInfo(string acntNbr, string name, short pin, double balance)
        {
            Console.WriteLine("=========================");
            Console.WriteLine("Account Information");
            Console.WriteLine("------------------------------");
            Console.Write("Account #: ");
            Console.WriteLine(acntNbr);
            Console.Write("Customer Name: ");
            Console.WriteLine(name);
            Console.Write("PIN: ");
            Console.WriteLine(pin);
            Console.Write("Balanace: ");
            Console.WriteLine(balance);
            Console.WriteLine("==============================");
        }
        public double GetDeposit(ref double amount)
        {
            double deposit = 225.55;
            amount += deposit;
            return deposit;
        }

        public double GetWithdrawal(ref double amount)
        {
            double withdrawal = 265.25d;
            amount -= withdrawal;
            return withdrawal;
        }

    }

}
