using KpopZtationLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using KpopZtationLab.Pattern;
using System.Web;
using KpopZtationLab.Factory;
using System.Web.UI.WebControls;
using System.IO;
using KpopZtationLab.Handler;

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

        public static string Save_Image(FileUpload file)
        {
            string path = "~/Assets/Images/Album/";
            string fileName = Path.GetFileName(file.PostedFile.FileName);
            string fullPath = path + fileName;
            string physicalPath = HttpContext.Current.Server.MapPath(fullPath);
            file.PostedFile.SaveAs(physicalPath);
            return fullPath;
        }

        public static string Create_Album(int ArtistID, string AlbumName, string AlbumImage, int AlbumPrice, int AlbumStock, string AlbumDescription)
        {
            //operasi pengecekan belom

            Album album = AlbumFactory.Create(ArtistID, AlbumName, AlbumImage, AlbumPrice, AlbumStock, AlbumDescription);
            AlbumHandler.Add(album);
            return "";
        }


        public static void Remove(int id)
        {
            Album album = repo.albums.Find(x => x.AlbumID == id).FirstOrDefault();
            repo.albums.Remove(album);
        }

        public static void Update(int albumID,string albumName,string albumImage,string albumDescription,int albumPrice,int albumStock)
        {
            var album = repo.albums.Find(x => x.AlbumID == albumID).FirstOrDefault(); 
            if(album!=null)
            {
                album.AlbumName = albumName;
                album.AlbumDescription = albumDescription;
                album.AlbumPrice = albumPrice;
                album.AlbumStock = albumStock;
                album.AlbumImage = albumImage;
                repo.albums.Update(album);
            }
        }

        public static string Validate(string albumName, string albumDescription, int albumPrice, int albumStock,FileUpload image)
        {
            if(!Album_IsUnique(albumName))
            {
                return "album name must be unique";
            }
            //sisanya belom
            return "";
        }
    }
}