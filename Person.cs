using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FomeUI
{
    public class Person
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        

        public string FullInfo
        {
            get
            {
                //ex: Tim Corey (test@test.com)
                return $"{ FirstName } { LastName} ({ EmailAddress})";
            }
        }
    }
}
