using KpopZtationLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.UI.WebControls;
using KpopZtationLab.Pattern;

namespace KpopZtationLab.Controllers
{
    public class ArtistController
    {
        const int MAX_FILE_SIZE = 2100000;
        public static bool Artist_IsUnique(string artistName)
        {
            if (artistName == "") return false;
            return repo.artists.Find(x=>x.ArtistName == artistName ).Count()==0;
        }

        public static bool Image_Less_Than_2mb(FileUpload file)
        {
            if (file == null) return false;
            return file.PostedFile.ContentLength < MAX_FILE_SIZE;
        }
        public static bool file_IsImageExtension(FileUpload file) 
        { 
            return true;
        }

        public static Artist Get_Artist_By_ID(int id)
        {
            return repo.artists.Find(x => x.ArtistID == id).FirstOrDefault();
        }

        public static List<Artist> Get_All_Artist()
        {
            return repo.artists.Find(x=>true).ToList();
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

        public static void Remove(int id)
        {
            var artist = repo.artists.Find(x=>x.ArtistID == id).FirstOrDefault();
            repo.artists.Remove(artist);
        }
    }
}