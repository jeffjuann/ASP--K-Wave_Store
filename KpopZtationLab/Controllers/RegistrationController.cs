using KpopZtationLab.Factory;
using KpopZtationLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtationLab.Pattern;

namespace KpopZtationLab.Controllers
{
    public class RegistrationController
    {
        public static bool Name_Length_Between_5_To_50(string name)
        {
            return (name.Length >= 5 && name.Length<=50);
        }

        public static bool Email_IsUnique(string email)
        {
            return repo.customers.Find(x=>x.CustomerEmail == email).Count()==0;
        }
        public static bool Gender_IsSelected(string value)
        {
            return (value != "") ? true:false ;
        }

        public static bool Address_Ends_With_Street(string address)
        {
            return address.EndsWith("Street");
        }

        public static bool Password_IsAlphanumeric(string password)
        {
            return password.All(character => char.IsLetterOrDigit(character)) && password!="";
        }

        public static void Register(string email,string name,string gender,string address,string password)
        {
            Customer newCustomer = CustomerFactory.Create(email,name, password, address, gender, "Customer");
            repo.customers.Add(newCustomer);
        }
        public static string Validate(string email, string name, string gender, string address, string password)
        {
            if (!Email_IsUnique(email))
            {
                return "email must be unique";
            };
            if (!Name_Length_Between_5_To_50(name))
            {
                return "name must be between 5 to 50";

            };
            if (!Gender_IsSelected(gender))
            {
                return "gender must not be null";
            };
            if (!Address_Ends_With_Street(address))
            {
                return "address must ends with 'Street'";
            };

            if (!Password_IsAlphanumeric(password))
            {
                return "password must be alphanumeric only";
            };
            return "";
        }
    }
}