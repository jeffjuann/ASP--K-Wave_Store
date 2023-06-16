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
        protected string role = "none";
        protected string getRole()
        {
            var userCookiesAuth = Request.Cookies["userAuth"];
            if (userCookiesAuth!=null)
            {
                return userCookiesAuth["role"].ToString();
            }
            else if(Session["role"]!=null)
            {
                return Session["role"].ToString();
            }
            Response.Redirect(Routes.Route.Login);
            return "";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                role = getRole();
                artists = ArtistController.Get_All_Artist();
                ArtistsGridView.DataSource = artists;
                ArtistsGridView.DataBind();
                AdminArtistsGridView.DataSource = artists;
                AdminArtistsGridView.DataBind();
            }
        }

  
        protected void AdminArtistsGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //int index = AdminArtistsGridView.NewSelectedIndex;
            GridViewRow row = AdminArtistsGridView.Rows[e.RowIndex];
            int ID = int.Parse(row.Cells[0].Text);
            ArtistController.Remove(ID);
            Response.Redirect(Routes.Route.Home);
        }

        protected void AdminArtistsGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //int index = AdminArtistsGridView.NewEditIndex;
            GridViewRow row = AdminArtistsGridView.Rows[e.NewEditIndex];
            string ID = row.Cells[0].Text;
            Response.Redirect(Routes.Route.UpdateArtist + "?ID=" + ID);
        }

        protected void AdminArtistsGridView_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = AdminArtistsGridView.Rows[e.NewSelectedIndex];
            string ID = row.Cells[0].Text;
            Response.Redirect(Routes.Route.ArtistDetail + "?ID=" + ID);
        }   
            
        protected void ArtistsGridView_SelectedIndexChanging(object  sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = AdminArtistsGridView.Rows[e.NewSelectedIndex];
            string ID = row.Cells[0].Text;
            Response.Redirect(Routes.Route.ArtistDetail + "?ID=" + ID);
        }

        protected void CreateArtist_Click(object sender, EventArgs e)
        {
            Response.Redirect(Routes.Route.InsertArtist);
        }
    }
}