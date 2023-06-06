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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["userAuth"] == null || Request.Cookies["userAuth"] == null)
                {
                    Response.Redirect(Routes.Route.Login);
                    return;
                }
                int userID = int.Parse(Session["ID"].ToString());
                carts = repo.carts.Find(x=>x.CustomerID==userID).ToList();
                CartGridView.DataSource = repo.carts.Find(x => x.CustomerID == userID).ToList();
                CartGridView.DataBind();
            }
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