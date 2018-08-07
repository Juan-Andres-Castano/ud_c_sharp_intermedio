using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        /*****************************************/
        //2   private DateTime _birthdate;

        /*  public void SetBirthdate(DateTime birthdate)
          {

              _birthdate = birthdate;

          }

          public DateTime GetBirthdate()
          {

              return _birthdate;

          }*/
        /*****************************************/
        //3
        // public DateTime Birthdate { get;  set; }  //2 es creada autom. and escondida. set es public puede ejeectaurse desde main
        public DateTime Birthdate { get; private set; }  //2 es creada autom. and escondida

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;

            }
        }

        public Person(DateTime birthdate )
        {
            Birthdate = birthdate;

        }
        /*
        {

            get {   return _birthdate; }
            set { _birthdate = birthdate; }


        }*/

        public String Name { get; set; }  //prop tab tab

        public string hlo { get; set; }

    }
}
