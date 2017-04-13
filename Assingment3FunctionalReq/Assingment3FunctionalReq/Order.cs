using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment3FunctionalReq
{
    class Order
    {
        private int cost;
        private Customer c;
        private int orderID;
        private static int ordercounter;


        public Order() { }
        public Order(Customer cus) { }
        public Customer getCustomer() {
            return c;
        }
        public void setCustomer(Customer cus) {}
        public void addBike(Bike bike) { }
        public int getCost()
        {
            return cost;
        }
        public void orderSummary() { }
        public int getOrderID() { return orderID; }
        public void setOrderID(int id) { }

        public void alterOrder(Order order) { }
        


    }
}
