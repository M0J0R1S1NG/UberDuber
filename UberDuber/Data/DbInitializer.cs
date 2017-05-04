
using UberDuber.Models;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UberDuber.Data
{
    public static class DbInitializer
    {
        
        public static void Initialize(UberDuberContext  context)
        {
            
            context.Database.EnsureCreated();
            
            // Look for any students.
            if (context.Orders.Any())
            {
                return;   // DB has been seeded
            }

            var orders = new Order[]
            {
            new Order{CustomerId=1,OrderDate=DateTime.Now ,Address1="21 Lakeview Ave",DeliveryDate=DateTime.Now,PostalCode="M6J3B2",Total=70,Weight=7},
            new Order{CustomerId=1,OrderDate=DateTime.Now ,Address1="Yonge and Dundas",DeliveryDate=DateTime.Now,PostalCode="M8H4R3",Total=35,Weight=3},

            };
            foreach (Order s in orders)
            {
                context.Orders.Add(s);
            }
            context.SaveChanges();

        var customers = new Customer[]
            {
            new Customer{FirstName="Andrew",LastName="Moore",UserName="Mojo",Status=1,Address1="21 Lakeview Ave",City="Toronto",Province="Ontario"},
            new Customer{FirstName="Tess",LastName="Moore",UserName="Taslema",Status=1,Address1="21 Lakeview Ave",City="Toronto",Province="Ontario"},
            new Customer{FirstName="Jeff",LastName="Hunter",UserName="Skidly",Status=1,Address1="21 lasndown Rd",City="Etobicoke",Province="Ontario"},
            };
            foreach (Customer c in customers)
            {
                context.Customers.Add(c);
            }
            context.SaveChanges();

           
        }
    }
}