using KpopZtationLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using KpopZtationLab.Pattern;
using System.Web;
namespace KpopZtationLab.Controllers
{
    public class AlbumController
    {
        public static bool Album_IsUnique(string albumName)
        {
            return repo.albums.Find(x=>x.AlbumName==albumName).Count()==0;
        }

        public static bool Image_Less_Than_2mb()
        {
            return false;
        }
        public static List<Album> Get_All_Albums(int artistID)
        {
            return repo.albums.Find(x => x.ArtistID == artistID).ToList();
        }
    }
}