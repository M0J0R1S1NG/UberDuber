using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UberDuber.Models
{
    public class Customer
    {

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public decimal PhoneNumber { get; set; }
        public string SpecialInstructions { get; set; }
        public int Status { get; set; }
        public Byte[] Photo { get; set; }

       

    }
}


