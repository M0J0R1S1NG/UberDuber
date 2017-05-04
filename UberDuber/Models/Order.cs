using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UberDuber.Models
{
    public class Order
    {

        public int ID { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Address1 { get; set; }
        public string PostalCode { get; set; }
        public decimal Total { get; set; }
        public decimal Weight { get; set; }
        public int PaymentType { get; set; }
        public string Details { get; set; }
        public string SpecialInstructions { get; set; }
        public int Status { get; set; }
        public int DriverId { get; set; }


    }
}


