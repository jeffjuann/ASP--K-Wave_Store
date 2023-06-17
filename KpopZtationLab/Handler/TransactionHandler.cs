using KpopZtationLab.Models;
using KpopZtationLab.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtationLab.Handler
{
    public class TransactionHandler
    {
        public static List<TransactionHeader> GetAllTransactionHeader()
        {
            return repo.transactionHeaders.Find(x => true).ToList();
        }
    }
}