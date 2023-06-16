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
    public class CustomerRespository:IRepository<Customer>
    {
        KpopZtationDBEntities context = Database.Connection;
        public void Add(Customer entity)
        {
            context.Customers.Add(entity);
            context.SaveChanges();
        }

        public void AddRange(List<Customer> entities)
        {
            context.Customers.AddRange(entities);
            context.SaveChanges();

        }

        public IEnumerable<Customer> Find(Expression<Func<Customer, bool>> predicate)
        {
            return context.Customers.Where(predicate.Compile());
        }

        public int NextID()
        {
            if (context.Customers.Count() == 0)
                return 0;
            return context.Customers.Max(x => x.CustomerID) + 1;
        }
        public void Remove(Customer entity)
        {
            context.Customers.Remove(entity);
            context.SaveChanges();

        }

        public void RemoveRange(List<Customer> entities)
        {
            context.Customers.RemoveRange(entities);
            context.SaveChanges();

        }

        public void Update(Customer updatedCustomer)
        {
            var customerToBeUpdated = Find(x=>x.CustomerID == updatedCustomer.CustomerID).FirstOrDefault();
            if (customerToBeUpdated != null)
            {
                customerToBeUpdated.CustomerAddress = updatedCustomer.CustomerAddress;
                customerToBeUpdated.CustomerEmail = updatedCustomer.CustomerEmail;
                customerToBeUpdated.CustomerName = updatedCustomer.CustomerName;
                customerToBeUpdated.CustomerPassword = updatedCustomer.CustomerPassword;
                customerToBeUpdated.CustomerRole = updatedCustomer.CustomerRole;
                customerToBeUpdated.CustomerGender = updatedCustomer.CustomerGender;
                context.SaveChanges();
            }
        }
    }
}