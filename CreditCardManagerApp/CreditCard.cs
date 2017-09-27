using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace CreditCardManagerApp
{
    class CreditCard
    {
        public String cardHolder { get; set; }
        public String creditCardNumber { get; set; }
        public String expirationDate { get; set; }
        public String telephoneNumber { get; set; }
        public String emailAddress { get; set; }
        public Boolean valid { get; set; }
        public CreditCardType type { get; set; }

        /// <summary>
        /// This is the constructor that creates a credit card object.
        /// </summary>
        /// <param name="cardHolder">The name of the card holder.</param>
        /// <param name="creditCardNumber">The credit card number.</param>
        /// <param name="expirationDate"></param>
        /// <param name="emailAddress"></param>
        /// <param name="valid"></param>
        /// <param name="type"></param>
        public CreditCard(String cardHolder, String creditCardNumber, String expirationDate, String telephoneNumber, String emailAddress, Boolean valid, CreditCardType type)
        {
            this.cardHolder = cardHolder;
            this.creditCardNumber = creditCardNumber;
            this.expirationDate = expirationDate;
            this.telephoneNumber = telephoneNumber;
            this.emailAddress = emailAddress;
            this.valid = valid;
            this.type = type;
        }
    }
}
