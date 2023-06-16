using KpopZtationLab.Factory;
using KpopZtationLab.Models;
using KpopZtationLab.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtationLab.Handler
{
    public class CustomerHandler
    {
        public static Customer getUserById(int id)
        {
            return repo.customers.Find(x => x.CustomerID == id).FirstOrDefault();
        }
  
        public static bool email_IsUnique(string email)
        {
            return repo.customers.Find(x => x.CustomerEmail == email).Count() == 0;
        }
        

        public static bool password_IsAlphanumeric(string password)
        {
            return password.All(character => char.IsLetterOrDigit(character)) && password != "";
        }

        public static void register(string email, string name, string gender, string address, string password)
        {
            Customer newCustomer = CustomerFactory.Create(email, name, password, address, gender, "Customer");
            repo.customers.Add(newCustomer);
        }
       
        public static void update(int id, string email, string name, string gender, string address, string password)
        {
            var user = repo.customers.Find(x => x.CustomerID == id).FirstOrDefault();
            if (user != null)
            {
                user.CustomerName = name;
                user.CustomerEmail = email;
                user.CustomerGender = gender;
                user.CustomerPassword = password;
                user.CustomerAddress = address;
                repo.customers.Update(user);
            }
        }
    }
}