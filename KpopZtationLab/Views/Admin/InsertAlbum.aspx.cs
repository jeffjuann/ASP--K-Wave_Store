using KpopZtationLab.Controllers;
using KpopZtationLab.Models;
using KpopZtationLab.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtationLab.Views.Admin
{
    public partial class InsertAlbum : System.Web.UI.Page
    {
        protected List<Album> albums = new List<Album>();
        protected Artist artist = new Artist();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id;
                bool success = int.TryParse(Request.QueryString["ID"], out id);
                if (!success)
                {
                    Response.Redirect(Routes.Route.Home);
                }
                artist = ArtistController.Get_Artist_By_ID(id);
                //album depends on artist so we need the id to fetch it
                AlbumGridView.DataSource = AlbumController.Get_All_Albums(id);
                AlbumGridView.DataBind();
                ArtistName.DataSource = repo.artists.Find(x => true).ToList();
            }
        }

        protected void AlbumGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = AlbumGridView.Rows[e.NewEditIndex];
        }
    }
}