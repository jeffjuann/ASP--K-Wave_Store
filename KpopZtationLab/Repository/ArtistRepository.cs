using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using KpopZtationLab.Interface;
using KpopZtationLab.Models;

namespace KpopZtationLab.Repository
{
    public class ArtistRepository : IRepository<Artist>
    {
        private KpopZtationDBEntities context;

        public ArtistRepository()
        {
            context = new KpopZtationDBEntities();
        }

        public void Save()
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                throw;
            }
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
            var artistToBeUpdated = context.Artists.Find(updatedArtist.ArtistID);
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
            return context.Artists.Where(predicate);
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

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
