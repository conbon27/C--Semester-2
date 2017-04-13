using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive10000
{
    class Recursion
    {
        static void Main(string[] args)
        {
            int k = 1;
            Even(k);
            // calls the Even method in the main & passes in the value of k to it.
        }
        public static void Even(int number)
        {
            if (number < 1 || number >=10000)
            { // sets a base case and returns the program if either a number < 1 or >=10000 is entered
                return;
            }
            if (number % 2 == 0) number++; 
            // for integer number with modulas 2=0, iterate through
            {
                Console.Write(number + ", ");
                // write the number out
                Even(number+1);
                // calls the Even method recursively 
            } 
        }
    }
}