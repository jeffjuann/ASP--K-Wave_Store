using KpopZtationLab.Factory;
using KpopZtationLab.Models;
using KpopZtationLab.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtationLab.Handler
{
    public class AlbumHandler
    {
        public static void Add(int ArtistID, string AlbumName, string AlbumImage, int AlbumPrice, int AlbumStock, string AlbumDescription)
        {
            Album album = AlbumFactory.Create(ArtistID, AlbumName, AlbumImage, AlbumPrice, AlbumStock, AlbumDescription);
            repo.albums.Add(album);
        }

        public static void Remove(int id)
        {
            Album album = repo.albums.Find(x => x.AlbumID == id).FirstOrDefault();
            repo.albums.Remove(album);
        }

        public static List<Album> getAlbum(int artistID)
        {
            return repo.albums.Find(x => x.ArtistID == artistID).ToList();
        }

        public static bool Album_Check_Unique(string albumName)
        {
            return repo.albums.Find(x => x.AlbumName == albumName).Count() == 0;
        }
    }
}