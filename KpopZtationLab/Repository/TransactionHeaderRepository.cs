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
    public class TransactionHeaderRepository:IRepository<TransactionHeader>
    {
        KpopZtationDBEntities context = Database.Connection;

        public void Add(TransactionHeader entity)
        {
            context.TransactionHeaders.Add(entity);
            context.SaveChanges();

        }

        public void AddRange(List<TransactionHeader> entities)
        {
            context.TransactionHeaders.AddRange(entities);
            context.SaveChanges();

        }

        public IEnumerable<TransactionHeader> Find(Expression<Func<TransactionHeader, bool>> predicate)
        {
            return context.TransactionHeaders.Where(predicate.Compile());
        }
        public int NextID()
        {
            if (context.TransactionHeaders.Count() == 0)
                return 0;
            return context.TransactionHeaders.Max(x => x.TransactionID) + 1;
        }

        public void Remove(TransactionHeader entity)
        {
            context.TransactionHeaders.Remove(entity);
            context.SaveChanges();

        }

        public void RemoveRange(List<TransactionHeader> entities)
        {
            context.TransactionHeaders.RemoveRange(entities);
            context.SaveChanges();

        }

        public void Update(TransactionHeader entity)
        {
            var ThToBeUpdated = Find(x=>x.TransactionID == entity.TransactionID).FirstOrDefault();
            if (ThToBeUpdated != null)
            {
                ThToBeUpdated.TransactionID = entity.TransactionID;
                ThToBeUpdated.TransactionDate = entity.TransactionDate;
                ThToBeUpdated.CustomerID = entity.CustomerID;
                context.SaveChanges();
            }
        }
    }
}