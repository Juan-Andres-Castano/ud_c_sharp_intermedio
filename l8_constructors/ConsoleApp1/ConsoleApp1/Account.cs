using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Account
    {
        private String accountNumber;
        private double balance;
        private String customerName;
        private String customerEmail;
        private String customerPhone;
      //  2. todos los constructores pequenos utilizan el grande

        public Account()
        :this("5678", 2.50, "default name", "default email", "default phone")
        {
             Console.WriteLine("empty constructor");

        }

        public Account(String customerName, String customerEmail, String customerPhone)
                :this("999", 100.5, customerName, customerEmail, customerPhone)
        {

        }

        public Account(String number, double balance, String customerName, String customerEmailAddress, String customerPhoneNumber)
        {
           Console.WriteLine("Account constructor with parameters");
            /// setAccountNumber(number); no settters in constructors
            this.accountNumber = number;
            this.balance = balance;
            this.customerName = customerName;
            this.customerEmail = customerEmailAddress;
            this.customerPhone = customerPhoneNumber;
        }

        public String getAccountNumber()
        {
            return accountNumber;
        }


        public double getBalance()
        {
            return balance;
        }

        public void setBalance(double balance)
        {
            this.balance = balance;
        }

        public String getCustomerName()
        {
            return customerName;
        }

        public void setCustomerName(String customerName)
        {
            this.customerName = customerName;
        }

        public String getCustomerEmail()
        {
            return customerEmail;
        }

        public void setCustomerEmail(String customerEmail)
        {
            this.customerEmail = customerEmail;
        }

        public String getCustomerPhone()
        {
            return customerPhone;
        }

        public void setCustomerPhone(String customerPhone)
        {
            this.customerPhone = customerPhone;
        }
    }
}
