using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtationLab.Models;
using KpopZtationLab.Pattern;
using KpopZtationLab.Repository;
using KpopZtationLab.Interface;
namespace KpopZtationLab.Controllers
{
    public class AuthenticationController:System.Web.UI.Page
    {
        // GET: Authentication
        static CustomerRespository customerRepo = new CustomerRespository();

        
        public static void Redirect_Based_On_Authentication_Status()
        {
            
        }

        public static Customer Authenticate(string email,string password)
        {
            //fetch data from CustomerRepository
            Customer user = customerRepo.Find(x => x.CustomerEmail == email && x.CustomerPassword == password).FirstOrDefault();
            return user;
        }
    }
}