using KpopZtationLab.Models;
using KpopZtationLab.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtationLab.Handler
{
    public class AuthenticationHandler
    {
 

        public static Customer authenticate(string email, string password)
        {
            //fetch data from CustomerRepository
            Customer user = repo.customers.Find(x => x.CustomerEmail == email && x.CustomerPassword == password).FirstOrDefault();
            return user;
        }
    }
}