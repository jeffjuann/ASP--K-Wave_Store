using KpopZtationLab.Controllers;
using KpopZtationLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtationLab.Views.Common
{
    public partial class ArtistDetail : System.Web.UI.Page
    {
        protected List<Album> albums;
        protected Artist artist;
        protected int? id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id;
                bool success = int.TryParse(Request.QueryString["id"], out id);
                if(!success)
                {
                    Response.Redirect(Routes.Route.Home);
                    return;
                }
                artist = ArtistController.Get_Artist_By_ID(id);
                //album depends on artist so we need the id to fetch it
                albums = AlbumController.Get_All_Albums(id); 
            }
        }

        protected void Navigate_Click(int id)
        {
            Response.Redirect("~/Views/Common/AlbumDetail.aspx?ID=" + id);
        }
    }
}