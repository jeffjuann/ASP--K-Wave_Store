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
            return repo.artists.Find(x=>x.ArtistName == artistName).Count()==0;
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
            var artistAlbum = repo.albums.Find(x => x.ArtistID == artist.ArtistID).ToList();
            var albumCarts = repo.carts.Find(x => x.AlbumID == artist.ArtistID).ToList();
            //optional
            var transactionDetails = repo.transactionDetails.Find(x => x.Album.ArtistID == artist.ArtistID).ToList();
            //begin deleting
            repo.albums.RemoveRange(artistAlbum);
            repo.carts.RemoveRange(albumCarts);
            repo.transactionDetails.RemoveRange(transactionDetails);
            repo.artists.Remove(artist);
        }

        public static void Update(int id,string name,string imageURL)
        {
            var artist = repo.artists.Find(x => x.ArtistID == id).FirstOrDefault();
            if(artist!=null)
            {
                artist.ArtistName = name;
                artist.ArtistImage = imageURL;
                repo.artists.Update(artist);
            }
        }

        public static string Validate(string name,FileUpload ArtistImageUpload)
        {
            if (!Artist_IsUnique(name))
            {
                return "artist is not unique";
            };
            if (
                !Image_Less_Than_2mb(ArtistImageUpload)
                && file_IsImageExtension(ArtistImageUpload))
            {
                return "File must be less than 2mb and an image type";
            };
            return "";
        }
    }
}