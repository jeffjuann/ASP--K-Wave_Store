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
    public class CartRepository:IRepository<Cart>
    {
        KpopZtationDBEntities context = Database.Connection;

        public void Add(Cart entity)
        {
            context.Carts.Add(entity);
            Save();

        }

        public void AddRange(List<Cart> entities)
        {
            context.Carts.AddRange(entities);
            Save();

        }

        public IEnumerable<Cart> Find(Expression<Func<Cart, bool>> predicate)
        {
            return context.Carts.Where(predicate.Compile());
        }

        public void Remove(Cart entity)
        {
            context.Carts.Remove(entity);
            Save();

        }

        public void RemoveRange(List<Cart> entities)
        {
            context.Carts.RemoveRange(entities);
            Save();

        }

        public void Save()
        {
          context.SaveChanges();
        }
        public void Update(Cart updatedCart)
        {
            var cartToBeUpdated = Find(x=>x.AlbumID == updatedCart.AlbumID && x.AlbumID == updatedCart.AlbumID).FirstOrDefault();
            if (cartToBeUpdated != null)
            {
                cartToBeUpdated.Qty = updatedCart.Qty;
                Save();
            }
        }
    }
}