using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KpopZtationLab.Models;
using KpopZtationLab.Pattern;
namespace KpopZtationLab.Views.Pages
{
    public partial class Cartpage : System.Web.UI.Page
    {
        protected List<Cart> carts;

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

        protected void Page_Load(object sender, EventArgs e)
        {

            //if (Session["userAuth"] == null || Request.Cookies["userAuth"] == null)
            //{
            //    Response.Redirect(Routes.Route.Login);
            //    return;
            //}
                
            int userID = getCurrentUserID();
            carts = repo.carts.Find(x=>x.CustomerID==userID).ToList();
            CartGridView.DataSource = repo.carts.Find(x => x.CustomerID == userID).ToList();
            CartGridView.DataBind();    
        }

        protected void CartGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void CartGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void CartGridView_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }
    }
}