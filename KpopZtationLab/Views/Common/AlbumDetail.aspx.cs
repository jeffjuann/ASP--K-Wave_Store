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
        public Album album = new Album();
        protected void Page_Load(object sender, EventArgs e)
        {
            //dapetin data user
            int albumID = int.Parse(Request.QueryString["ID"]);
            album = repo.albums.Find(x => x.AlbumID == albumID).FirstOrDefault();
        }

        //protected void decreaseProduct_Click(object sender, EventArgs e)
        //{
        //    if(quantity>0)
        //    {
        //        quantity -= 1;
        //        quantityTxt.Text = quantity.ToString();
        //    }
        //}

        //protected void addProduct_Click(object sender, EventArgs e)
        //{
        //    if(quantity<=album.AlbumStock)
        //    {
        //        quantity += 1;
        //        quantityTxt.Text = quantity.ToString();
        //    }
        //}
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
            int userID = getCurrentUserID();
            int selectedQuantity = int.Parse(QuantityTxt.Text);
            if (selectedQuantity > 0 && selectedQuantity<=album.AlbumStock)
            {
                CartController.Add(userID, album.AlbumID, selectedQuantity);
            }
        }
    }
}