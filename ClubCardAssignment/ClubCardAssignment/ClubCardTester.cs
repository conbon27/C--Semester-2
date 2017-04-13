using System;

namespace ClubCardAssignment
{
    class ClubCardTester
    {
        static int Main(string[] args)
        {
            ClubCard tesco = new ClubCard();          

            double purchaseAmount = 0;
            double usedPoints = 0;
            double Points = 0;
            // instantiates double variables purchaseAmount, usedPoints & Points to be used below

            tesco.AddNewMember(tesco);
            // passes in instance of clubcard "tesco" to the adding method
            tesco.MemberDetails(ref tesco);
            // calls the display method for the instance of tesco (passed-by reference) 
            tesco.GetNewPoints(ref purchaseAmount);
            // adds points to total based upon user input(uses the pass-by-reference method)
            Console.WriteLine("After pass-by reference: Confirmed points balance is " + tesco.Points);
            tesco.SpendPoints(ref usedPoints);
            // deducts points based on user input (uses the pass-by-reference method)
            Console.WriteLine("Points used: " + usedPoints);
            Console.WriteLine("After deduction: Confirmed points balance is " + tesco.Points);
            Console.WriteLine("Press return to clear Points data.");
            Console.ReadKey();
            // clears points data using the out method which was set to 0.
            tesco.ClearData(out Points);
            Console.ReadKey();
            return 0; // return statement for main method
        } // closes main
    } // closes class
} 
