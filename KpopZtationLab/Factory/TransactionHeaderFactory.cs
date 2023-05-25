using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtationLab.Models;

namespace KpopZtationLab.Factory
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader Create(int CustomerID, System.DateTime TransactionDate)
        {
            var transaction = new TransactionHeader();
            transaction.CustomerID = CustomerID;
            transaction.TransactionDate = TransactionDate;
            return transaction;
        }
    }
}