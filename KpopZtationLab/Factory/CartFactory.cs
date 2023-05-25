using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtationLab.Models;
namespace KpopZtationLab.Factory
{
    public class CartFactory
    {
        public static Cart Create(int CustomerID, int AlbumID, int Qty)
        {
            var cart = new Cart();
            cart.CustomerID = CustomerID;
            cart.AlbumID = AlbumID;
            cart.Qty = Qty;
            return cart;
        }
    }
}