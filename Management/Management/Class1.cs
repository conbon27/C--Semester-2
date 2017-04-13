using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByRef

{
    class test
    {
        public static int Main()
        {
            Management man = new Management();
            string acntNbr = "248-058721-133";
            string name = "Ann Kelly";
            short pin = 1234;
            double balance = 4000.50D;

            double? depositAmount = null;
            double? withdrawalAmount = null;

            man.ShowAccInfo(acntNbr, name, pin, balance);
            depositAmount = man.GetDeposit(ref balance);

            Console.WriteLine("After a new deposit: ");
            man.ShowAccInfo(acntNbr, name, pin, balance);

            withdrawalAmount = man.GetWithdrawal(ref balance);

            Console.WriteLine("After a withdrawl: ");
            man.ShowAccInfo(acntNbr, name, pin, balance);

            Console.ReadKey();
            return 0;
        }
    }
}
