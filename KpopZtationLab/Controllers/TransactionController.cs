using KpopZtationLab.Handler;
using KpopZtationLab.Models;
using KpopZtationLab.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtationLab.Controllers
{
    public class TransactionController
    {
        public static List<TransactionHeader> GetAll()
        {
            return TransactionHandler.GetAllTransactionHeader();
        }
        public static int GetTransactionHeaderTotal(TransactionHeader th)
        {
            int total = 0;
            foreach(var item in th.TransactionDetails)
            {
                total += item.Qty * item.Album.AlbumPrice;
            }
            return total;
        }
        public static int GetTransactionDetailTotal(TransactionDetail th)
        {
            int total = 0;
            total += th.Qty * th.Album.AlbumPrice;
            return total;
        }
    }
}