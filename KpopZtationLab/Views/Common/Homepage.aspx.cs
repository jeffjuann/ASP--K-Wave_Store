using KpopZtationLab.Routes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using KpopZtationLab.DummyClass;
using KpopZtationLab.Controllers;
using KpopZtationLab.Models;

namespace KpopZtationLab.Views.Common
{
    public partial class Homepage : System.Web.UI.Page
    {
        protected List<Artist> artists;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["userAuth"] == null || Request.Cookies["userAuth"] == null)
                {
                    //Response.Redirect(Routes.Route.Login);
                    //return;
                } 
                artists = ArtistController.Get_All_Artist();
                ArtistRepeater.DataSource = artists;
                ArtistRepeater.DataBind();
            }
        }

        protected void Delete_Artist(object sender, CommandEventArgs e)
        {

            int ID = int.Parse((string)e.CommandArgument);
            ArtistController.Remove(ID);
            Response.Redirect(Routes.Route.Home);
        }
        protected void Update_Artist(object sender, CommandEventArgs e)
        {
            string ID = (string)e.CommandArgument;
            Response.Redirect(Routes.Route.UpdateArtist+"?ID="+ID);
        }
    }
}