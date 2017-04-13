using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment3FunctionalReq
{
    class Payment
    {
        private Order order;
        private string cardNumber;
        private string cardName;
        private string cvv;
        private string nameOnCard;

        public Payment(Order order) { }
        public void setOrder(Order ord) { }
        public Order getOrder() { return order; }
        public void setCardNumber(string cardNumber) { }
        public string getCardNumber() { return cardNumber; }
        public string getNameOnCard() { return nameOnCard; }
        public void setNameOnCard(string nameOnCard) { }
        public string getCVV() { return cvv; }
        public void setCVV(string cvv) { }
        public void verifyPayment() { }
        public void paymentEmail() { }

    }
}
