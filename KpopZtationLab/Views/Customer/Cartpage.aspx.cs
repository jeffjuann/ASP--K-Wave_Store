﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KpopZtationLab.Controllers;
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
            int userID = getCurrentUserID();
            carts = CartController.Get_user_by_id(userID);
            CartRepeater.DataSource = carts;
            CartRepeater.DataBind();
        }

        protected void CartRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                int albumID = int.Parse(e.CommandArgument.ToString());
                int userID = getCurrentUserID();
                CartController.Remove(userID, albumID);
                Response.Redirect(Routes.Route.Home);
            }
        }

        protected void CheckOutBtn_Click(object sender, EventArgs e)
        {
            int id = getCurrentUserID();
            CartController.CheckOut(id);
            Response.Redirect(Routes.Route.Home);
        }
    }
}
