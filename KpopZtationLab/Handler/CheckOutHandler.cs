using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtationLab.Repository;
using KpopZtationLab.Pattern;
namespace KpopZtationLab.Handler
{
    public class CheckOutHandler
    {
        public static void CheckOutCart(int id)
        {
            var cartsToBeDeleted = repo.carts.Find(x => x.CustomerID == id).ToList();
            repo.carts.RemoveRange(cartsToBeDeleted);
        }
    }
}