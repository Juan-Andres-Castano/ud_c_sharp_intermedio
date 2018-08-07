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
            /*  var customer = new Customer(1);
              customer.Orders.Add(new Order());
              customer.Orders.Add(new Order());

              customer.Promote();

              Console.WriteLine(customer.Orders.Count);*/

            /*****************************************/
            //2. person.cs
            /* var person = new Person();
             person.SetBirthdate(new DateTime(1982,1,1));
             person.GetBirthdate();
             Console.WriteLine(person.GetBirthdate());*/
            /*****************************************/
            //3. person.cs
            var person = new Person(new DateTime(1982, 1, 1));
          //  person.Birthdate = ;
            Console.WriteLine(person.Age);

        }
    }
}
