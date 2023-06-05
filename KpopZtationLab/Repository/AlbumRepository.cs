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
    public class AlbumRepository : IRepository<Album>
    {
        public static KpopZtationDBEntities context = Database.Connection;
        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Album updatedAlbum)
        {
            var albumToBeUpdated = Find(x=>x.AlbumID == updatedAlbum.AlbumID).FirstOrDefault();
            if (albumToBeUpdated != null)
            {
                albumToBeUpdated.AlbumDescription = updatedAlbum.AlbumDescription;
                albumToBeUpdated.AlbumName = updatedAlbum.AlbumName;
                albumToBeUpdated.AlbumPrice = updatedAlbum.AlbumPrice;
                albumToBeUpdated.AlbumStock = updatedAlbum.AlbumStock;
                albumToBeUpdated.ArtistID = updatedAlbum.ArtistID;
                albumToBeUpdated.AlbumImage = updatedAlbum.AlbumImage;
                Save();
            }
        }

        public int NextID()
        {
            if(context.Albums.Count() == 0)
                return 0;
            return context.Albums.Max(x=>x.AlbumID)+1;
        }

        public void Add(Album albumToAdd)
        {
            context.Albums.Add(albumToAdd);
            context.SaveChanges();
        }
        public IEnumerable<Album> Find(Expression<Func<Album, bool>> predicate)
        {
            return context.Albums.Where(predicate.Compile());
        }

        public void AddRange(List<Album> entities)
        {
            context.Albums.AddRange(entities);
            Save();
        }

        public void Remove(Album entity)
        {
            context.Albums.Remove(entity);
            Save();
        }

        public void RemoveRange(List<Album> entities)
        {
            context.Albums.RemoveRange(entities);
            Save();
        }

    }
}