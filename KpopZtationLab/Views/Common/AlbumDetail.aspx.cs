using KpopZtationLab.Factory;
using KpopZtationLab.Models;
using KpopZtationLab.Pattern;
using KpopZtationLab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KpopZtationLab.Controllers;
namespace KpopZtationLab.Views.Common
{
    public partial class AlbumDetail : System.Web.UI.Page
    {
        public int quantity = 0;
        public Artist artist = new Artist();
        public Album album = new Album();
        public List<Album> albums = new List<Album>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //dapetin data user

            int artistID = int.Parse(Request.QueryString["ArtistID"]);
            int albumID = int.Parse(Request.QueryString["AlbumID"]);
            artist = repo.artists.Find(x => x.ArtistID == artistID).FirstOrDefault();
            album = repo.albums.Find(x => x.AlbumID == albumID).FirstOrDefault();
            albums = repo.albums.Find(x => x.ArtistID == artistID).Where(x=>x.AlbumID!=albumID).ToList();
        }

        protected void decreaseProduct_Click(object sender, EventArgs e)
        {
            if(quantity>0)
            {
                quantity -= 1;
            }
        }

        protected void addProduct_Click(object sender, EventArgs e)
        {
            if(quantity<=album.AlbumStock)
            {
                quantity += 1;
            }
        }
        protected int getCurrentUserID()
        {
            var userCookies = Request.Cookies["userAuth"];
            if (userCookies != null)
            {
                return int.Parse(userCookies["id"]);
            }
            else if (Session["userAuth"] != null)
            {
                var userID = Session["userAuth"].ToString();
                return int.Parse(userID);
            }

            Response.Redirect(Routes.Route.Home);
            return 0; // Return a default value or choose an appropriate alternative.
        }
        protected void addToCartBtn_Click(object sender, EventArgs e)
        {
            //int userID = getCurrentUserID();
            //CartController.Add(userID,album.AlbumID,quantity);
           
        }
    }
}