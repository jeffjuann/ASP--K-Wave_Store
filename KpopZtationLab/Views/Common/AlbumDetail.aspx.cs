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

namespace KpopZtationLab.Views.Common
{
    public partial class AlbumDetail : System.Web.UI.Page
    {
        public Artist artist = new Artist();
        public Album album = new Album();
        public List<Album> albums = new List<Album>();
        protected void Page_Load(object sender, EventArgs e)
        {
            int artistID = int.Parse(Request.QueryString["ArtistID"]);
            int albumID = int.Parse(Request.QueryString["AlbumID"]);
            artist = repo.artists.Find(x => x.ArtistID == artistID).FirstOrDefault();
            album = repo.albums.Find(x => x.AlbumID == albumID).FirstOrDefault();
            albums = repo.albums.Find(x => x.ArtistID == artistID).Where(x=>x.AlbumID!=albumID).ToList();
        }
    }
}