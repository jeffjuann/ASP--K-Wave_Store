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
        protected int id;
        protected string role = "";
        protected void Page_Load(object sender, EventArgs e)
        {
                bool success = int.TryParse(Request.QueryString["id"], out id);
                if(!success)
                {
                    Response.Redirect(Routes.Route.Home);
                    return;
                }
                role = getRole();
                artist = ArtistController.Get_Artist_By_ID(id);
                //album depends on artist so we need the id to fetch it
                albums = AlbumController.Get_All_Albums(id);
                AlbumListGridView.DataSource = albums;
                AlbumListGridView.DataBind();
                AlbumListGridViewCstm.DataSource = albums;
                AlbumListGridViewCstm.DataBind();
        }

        protected string getRole()
        {
            var userCookiesAuth = Request.Cookies["userAuth"];
            if (userCookiesAuth != null)
            {
                return userCookiesAuth["role"].ToString();
            }
            else if (Session["role"] != null)
            {
                return Session["role"].ToString();
            }
            return "";
        }


        protected void NavigateToInsertAlbum_Click(object sender, EventArgs e)
        {
            int id;
            bool success = int.TryParse(Request.QueryString["id"], out id);
            if (!success)
            {
                Response.Redirect(Routes.Route.Home);
                return;
            }
            Response.Redirect(Routes.Route.InsertAlbum+"?ID=" + id);
        }

        protected void AlbumListGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int ID = Convert.ToInt32(AlbumListGridView.DataKeys[e.RowIndex].Value);
            AlbumController.Remove(ID);
            Response.Redirect(Routes.Route.ArtistDetail + "?ID=" + id);
        }

        protected void AlbumListGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int ID = Convert.ToInt32(AlbumListGridView.DataKeys[e.NewEditIndex].Value);
            Response.Redirect(Routes.Route.UpdateAlbum + "?ID=" + ID);
        }

        protected void AlbumListGridView_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            int ID = Convert.ToInt32(AlbumListGridView.DataKeys[e.NewSelectedIndex].Value);
            Response.Redirect(Routes.Route.AlbumDetail + "?ID=" + ID);
        }

        protected void AlbumListGridViewCstm_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int ID = Convert.ToInt32(AlbumListGridViewCstm.DataKeys[e.RowIndex].Value);
            AlbumController.Remove(ID);
            Response.Redirect(Routes.Route.ArtistDetail + "?ID=" + id);
        }

        protected void AlbumListGridViewCstm_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int ID = Convert.ToInt32(AlbumListGridViewCstm.DataKeys[e.NewEditIndex].Value);
            Response.Redirect(Routes.Route.UpdateAlbum + "?ID=" + ID);
        }

        protected void AlbumListGridViewCstm_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            int ID = Convert.ToInt32(AlbumListGridViewCstm.DataKeys[e.NewSelectedIndex].Value);
            Response.Redirect(Routes.Route.AlbumDetail + "?ID=" + ID);
        }
    }
}