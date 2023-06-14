using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtationLab.Pattern;
using KpopZtationLab.Factory;
namespace KpopZtationLab.Controllers
{
    public class CartController
    {
        public static void Add(int customerID,int albumID,int quantity)
        {
            var userAlbumExist = repo.carts.Find(x => x.CustomerID == customerID && x.AlbumID == albumID).FirstOrDefault();
            if(userAlbumExist!=null)
            {
                userAlbumExist.Qty += quantity;
                repo.albums.Save();
            }
            else
            {
                var newUserAlbum = CartFactory.Create(customerID,albumID,quantity);
                repo.carts.Add(newUserAlbum);
            }
        }
    }
}