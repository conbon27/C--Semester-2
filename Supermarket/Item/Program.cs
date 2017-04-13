using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public class Item
    {
        public long itemNumber;
        public string ItemName;
        public string size;
        public decimal unitPrice;

        public void CreateItem()
        {
            itemNumber = 1234;
            ItemName = "Cologne Spray";
            size = "1.5oz";
            unitPrice = 9.99m;
        }
        public void Describe()
        {
            Console.WriteLine("Supermarket");
            Console.Write("Item #: ");
            Console.WriteLine(itemNumber);
            Console.Write("Item Name: ");
            Console.WriteLine(ItemName);
            Console.Write("Item Size: ");
            Console.WriteLine(size);
            Console.Write("Price: ");
            Console.WriteLine(unitPrice);
        }
    }
}
