using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtationLab.Models;

namespace KpopZtationLab.Factory
{
    public class TransactionDetailsFactory
    {
        public static TransactionDetail Create(int transactionHeaderID,int AlbumID, int Qty)
        {
            var transaction = new TransactionDetail();
            transaction.TransactionID = transactionHeaderID;
            transaction.AlbumID = AlbumID;
            transaction.Qty = Qty;
            return transaction;
        }
    }
}