using KpopZtationLab.Factory;
using KpopZtationLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtationLab.Pattern;
using KpopZtationLab.Handler;

namespace KpopZtationLab.Controllers
{
    public class CustomerController
    {
        public static Customer getUserByID(int id)
        {
           return CustomerHandler.getUserById(id);
        }
        public static bool Name_Length_Between_5_To_50(string name)
        {
            return (name.Length >= 5 && name.Length <= 50);
        }

        public static bool Email_IsUnique(string email)
        {
            return CustomerHandler.email_IsUnique(email);
        }
        public static bool Gender_IsSelected(string value)
        {
            return (value != "") ? true : false;
        }

        public static bool Address_Ends_With_Street(string address)
        {
            return address.EndsWith("Street");
        }

        public static bool Password_IsAlphanumeric(string password)
        {
            return CustomerHandler.password_IsAlphanumeric(password);
        }

        public static void Register(string email, string name, string gender, string address, string password)
        {
            CustomerHandler.register(email, name, gender, address, password);
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
        public static void Update(int id, string email, string name, string gender, string address, string password)
        {
            CustomerHandler.update(id, email, name, gender, address, password);
        }
    }
}