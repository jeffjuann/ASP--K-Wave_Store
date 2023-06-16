using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtationLab.Pattern;
using KpopZtationLab.Factory;
using KpopZtationLab.Models;

namespace KpopZtationLab.Controllers
{
    public class CartController
    {
        public static void Add(int customerID,int albumID,int quantity)
        {
            var albumToCart = repo.carts.Find(x => x.CustomerID == customerID && x.AlbumID == albumID).FirstOrDefault();
            if(albumToCart != null)
            {
                albumToCart.Qty += quantity;
                repo.carts.Update(albumToCart);
            }
            else
            {
                var newUserAlbum = CartFactory.Create(customerID,albumID,quantity);
                repo.carts.Add(newUserAlbum);
            }
        }
        public static void Remove(int userID,int albumID)
        {
            var cartItemTobeDeleted = repo.carts.Find(x => x.CustomerID == userID && x.AlbumID == albumID).FirstOrDefault();
            if(cartItemTobeDeleted!=null)
            {
                repo.carts.Remove(cartItemTobeDeleted);
            }
        }
        public static List<Cart> GetCarts(int id)
        {
            return repo.carts.Find(x => x.CustomerID == id).ToList();
        }

        public static void CheckOut(int id)
        {
            var cartTobeCheckout = repo.carts.Find(x => x.CustomerID == id).ToList();
            var transactionHeader = TransactionHeaderFactory.Create(id, DateTime.Now);
            repo.transactionHeaders.Add(transactionHeader);
            foreach(var cartItem in cartTobeCheckout)
            {
                var transactionDetail = TransactionDetailsFactory.Create(transactionHeader.TransactionID, cartItem.AlbumID, cartItem.Qty);
                //do update to the quantity
                var decreaseAlbumQty = repo.albums.Find(x => x.AlbumID == cartItem.AlbumID).FirstOrDefault();
                decreaseAlbumQty.AlbumStock -= cartItem.Qty;
                repo.albums.Update(decreaseAlbumQty);
                repo.transactionDetails.Add(transactionDetail);
            }
            repo.carts.RemoveRange(cartTobeCheckout);
        }
        public static string ValidateQuantity(int quantity, int maxQuantity)
        {
            if (quantity == 0) return "quantity must not be 0";
            if (quantity > maxQuantity) return "quantity must not go above " + maxQuantity;
            return "";
        }
    }
}