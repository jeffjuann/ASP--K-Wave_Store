using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtationLab.Models;
using KpopZtationLab.Factory;
using KpopZtationLab.Pattern;
using KpopZtationLab.Interface;
using System.Linq.Expressions;
using System.Data.Entity.Validation;

namespace KpopZtationLab.Repository
{

    public class ArtistRepository:IRepository<Artist>
    {
        KpopZtationDBEntities context = Database.Connection;

        public void Save()
        {
           context.SaveChanges();
        }
        public void Add(Artist artistToAdd)
        {
            context.Artists.Add(artistToAdd);
            Save();
        }
        public int NextID()
        {
            if (context.Artists.Count() == 0)
                return 0;
            return context.Artists.Max(x => x.ArtistID) + 1;
        }
        public void Update(Artist updatedArtist)
        {
            var artistToBeUpdated = Find(x=>x.ArtistID == updatedArtist.ArtistID).FirstOrDefault();
            if (artistToBeUpdated != null)
            {
                artistToBeUpdated.ArtistName = updatedArtist.ArtistName;
                artistToBeUpdated.ArtistImage = updatedArtist.ArtistImage;
                Save();
            }
        }

        public void Remove(Artist entity)
        {
            context.Artists.Remove(entity);
            Save();
        }

        public IEnumerable<Artist> Find(Expression<Func<Artist, bool>> predicate)
        {
            return context.Artists.Where(predicate.Compile());
        }

        public void RemoveRange(List<Artist> entities)
        {
            context.Artists.RemoveRange(entities);
            Save();
        }

        public void AddRange(List<Artist> entities)
        {
            context.Artists.AddRange(entities);
            Save();
        }
    }
}