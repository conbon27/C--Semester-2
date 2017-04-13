using System;

namespace ClubCardAssignment
{
    class ClubCard
    {
        private string name;
        private string address;
        private string email;
        private long telephone;
        private int memberNumber;
        private int points;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
            public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
            public long Phone
        {
            get
            {
                return telephone;
            }
            set
            {
                telephone = value;
            }
        }
            public int MemberNumber
        {
            get
            {
                return memberNumber;
            }
            set
            {
                memberNumber = value;
            }
        }
            public int Points
        {
            get
            {
                return points;
            }
            set
            {
                points = value;
            }
        }// use of properties to set getters & setters for the private variables relating to ClubCard
        

        public void AddNewMember(ClubCard x)// pass by value
        {
            Console.Write("Please enter new member's full name:");
            x.Name = Console.ReadLine();
            Console.Write("Please enter address:");
            x.Address = Console.ReadLine();
            Console.Write("Please enter email address:");
            x.Email = Console.ReadLine();
            Console.Write("Please enter phone number:");
            x.Phone = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter Member Number: ");
            x.MemberNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter points balance: ");
            x.Points = Convert.ToInt32(Console.ReadLine());
            // Method for creating new member entry of type clubcard
        }
        
        public void MemberDetails(ref ClubCard x)//uses the pass by reference to pass object
        {
            Console.WriteLine("For Member " + x.MemberNumber);
            Console.WriteLine("Name: " + x.Name);
            Console.WriteLine("Address: " + x.Address);
            Console.WriteLine("Email: " + x.Email);
            Console.WriteLine("Your current Points balance is Points: " + x.Points);
            // method which displays details of the members of the ClubCard scheme.
        }

        public int GetNewPoints(ref double purchaseAmount)//uses the pass by reference to pass object
        {
            Console.WriteLine("How much did you purchase? \nPoints equal 20% of purchase price:");
            purchaseAmount = Convert.ToInt32(Console.ReadLine());
            Points += Convert.ToInt32(purchaseAmount *(.2));
            Console.WriteLine("New points balance is " + Points);
            return points;        
            // method which calculates how many points are earned based on 20% of a purchased good    
        }
        
        public int SpendPoints(ref double usedPoints)//uses the reference method to pass object
        {
            Console.WriteLine("How many points would you like to use? ");
            usedPoints = Console.Read();
            Points -= Convert.ToInt32(usedPoints); 
            Console.WriteLine("New points balance is " + Points);
            return points;
            // methods which subtracts points from total points based on how many are to be spent
        }
        public int ClearData(out double Points)
        {// uses the out reference method to pass object
            Points = 0;
            Console.WriteLine("Following deletion, Points are now " + Points);
            return points;
        }
    } // closes class
} // closes namespace
