using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PresentationObject
    {
        public int width { get; set; }
        public int height { get; set; }


        public void Copy()
        {
            Console.WriteLine( "object copied");
        }

        public void Duplicate()
        {
            Console.WriteLine("objecti duplicated");
        }
    }
}
