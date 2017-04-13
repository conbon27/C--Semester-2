using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment3FunctionalReq
{
    class Email
    {
        private Customer c;
        private Order order;

        public Email(Order order)
        {
            c = order.getCustomer();
        }
        public void paymentSuccess()
        {
            Console.WriteLine("Payment was successful. An email will be sent to the customer containing confirmation & order details.");
            string succcessMessage = ("In relation to the order shown below, the payment was successful - Order Confirmed");
            sendEmail(succcessMessage);
        }
        public void paymentFail()
        {
            Console.WriteLine("Payment was unsuccessful. An email will be sent to the customer");
            string failMessage = ("In relation to the order shown below, the payment was unsuccessful - Order cancelled");
            sendEmail(failMessage);
        }
        public void sendEmail(string emailContent)
        {
            Console.WriteLine("\nContent of email sent to the customer: ");
            Console.WriteLine("Send to: "+c.getEmailAddress());
            Console.WriteLine("Dear " + c.getCustomerName() + ", \n");
            Console.WriteLine("\t" + emailContent);
            order.orderSummary();
        }
    }
}
