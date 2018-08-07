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
            UseParams();
            UsePoints();


        }

        static void UseParams()
        {

            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));

            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
        }

        static void UsePoints()
        {

            try
            {

                var point = new Point(10, 20);

                 // point.move(new Point(40, 60));
                 point.move(null);

                Console.WriteLine("pint is at ({0}, {1})", point.x, point.y);


                 point.move(100, 200);
                 Console.WriteLine("pint is at ({0}, {1})", point.x, point.y);


            }
            catch (Exception)
            {

               // throw;
                Console.WriteLine("unexpecte error");
            }
        }
    }
}
