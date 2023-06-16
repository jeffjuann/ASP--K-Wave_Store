using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtationLab.Pattern;
using KpopZtationLab.Factory;
using KpopZtationLab.Models;
using KpopZtationLab.Handler;

namespace KpopZtationLab.Controllers
{
    public class CartController
    {
        public static void Add(int customerID,int albumID,int quantity)
        {
            CartHandler.add(customerID, albumID, quantity);
        }
        public static void Remove(int userID,int albumID)
        {
            CartHandler.remove(userID, albumID);
        }

        public static List<Cart> GetCarts(int id)
        {
            return CartHandler.getCarts(id);
        }

        public static void CheckOut(int id)
        {
            CartHandler.checkOut(id);
        }
        public static string ValidateQuantity(int quantity, int maxQuantity)
        {
            if (quantity == 0) return "quantity must not be 0";
            if (quantity > maxQuantity) return "quantity must not go above " + maxQuantity;
            return "";
        }

        public static List<Cart> Get_user_by_id(int userID)
        {
            return repo.carts.Find(x => x.CustomerID == userID).ToList();
        }
    }
}