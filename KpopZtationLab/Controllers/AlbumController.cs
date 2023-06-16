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
            return AlbumHandler.Album_Check_Unique(albumName);
        }

        public static bool Image_Less_Than_2mb()
        {
            return false;
        }
        public static List<Album> Get_All_Albums(int artistID)
        {
            return AlbumHandler.getAlbum(artistID);
        }

        public static string Save_Image(FileUpload file)
        {
            string path = "/Assets/Images/Artists/";
            string fileName = Path.GetFileName(file.PostedFile.FileName);
            string fullPath = path + fileName;
            string physicalPath = HttpContext.Current.Server.MapPath(fullPath);
            file.PostedFile.SaveAs(physicalPath);
            return fullPath;
        }

        public static string Create_Album(int ArtistID, string AlbumName, string AlbumImage, int AlbumPrice, int AlbumStock, string AlbumDescription)
        {
            //operasi pengecekan belom

            AlbumHandler.Add(ArtistID, AlbumName, AlbumImage, AlbumPrice, AlbumStock, AlbumDescription);
            return "";
        }


        public static void Remove(int id)
        {
            AlbumHandler.Remove(id);
        }
    }
}