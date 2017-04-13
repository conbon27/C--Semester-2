using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment3FunctionalReq
{
    class Inventory
    {
        List<Bike> bikes = new List<Bike>();

         
        public Inventory() {
        foreach(Bike b in bikes)
            {
                Console.WriteLine(b);
            }
                
                    }



    }
}
