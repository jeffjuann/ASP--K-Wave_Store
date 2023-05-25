using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtationLab.Models;
using KpopZtationLab.Factory;
using KpopZtationLab.Pattern;
using KpopZtationLab.Interface;
using System.Linq.Expressions;

namespace KpopZtationLab.Repository
{
    public class TransactionDetailsRepository:IRepository<TransactionDetail>
    {
        KpopZtationDBEntities context = Database.Connection;

        public void Add(TransactionDetail entity)
        {
            context.TransactionDetails.Add(entity);
            Save();

        }

        public void AddRange(List<TransactionDetail> entities)
        {
            context.TransactionDetails.AddRange(entities);
            Save();

        }

        public IEnumerable<TransactionDetail> Find(Expression<Func<TransactionDetail, bool>> predicate)
        {
            return context.TransactionDetails.Where(predicate.Compile());
        }

        public void Remove(TransactionDetail entity)
        {
            context.TransactionDetails.Remove(entity);
            Save();

        }

        public void RemoveRange(List<TransactionDetail> entities)
        {
            context.TransactionDetails.RemoveRange(entities);
            Save();

        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(TransactionDetail entity)
        {
            var TdToBeUpdated = Find(x=>x.TransactionID == entity.TransactionID).FirstOrDefault();
            if (TdToBeUpdated != null)
            {
                TdToBeUpdated.Qty = entity.Qty;
                Save();
            }
        }
    }
}