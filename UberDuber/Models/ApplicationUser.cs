using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace UberDuber.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        String StreetName;
        String PostalCode;
        String StreeNumber;
        String City;
        String Province;
        String Country;
        DateTime DoB;
        


    }
}
