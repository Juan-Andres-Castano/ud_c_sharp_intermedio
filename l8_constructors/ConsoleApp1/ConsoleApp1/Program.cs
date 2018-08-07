using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    
    class Program
    {
        static void Main(string[] args)
        {

            var customer = new Customer(1, "juan");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            //var order = new Order();

            // customer.Orders = new List<Order>();

            // customer.Orders.Add(order);
            Account juanAccount = new Account("1243456", 0.00, "juan andres", "juan@npetronic.com", "3423424");
            Console.WriteLine(juanAccount.getAccountNumber());
            Console.WriteLine(juanAccount.getBalance());
            Console.WriteLine(juanAccount.getCustomerEmail());


            Account timsAcccount = new Account("Tim", "email", "1333");
            Console.WriteLine(timsAcccount.getAccountNumber() + " name is " + timsAcccount.getCustomerName());






        }
    }
}
