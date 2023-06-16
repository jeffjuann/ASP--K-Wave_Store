using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using KpopZtationLab.Routes;
namespace KpopZtationLab.Views
{
    public partial class Master : System.Web.UI.MasterPage
    {
        private HtmlGenericControl customerNavbar;
        private HtmlGenericControl adminNavbar;
        private HtmlGenericControl guestNavbar;
        protected void showNavbar(string nav)
        {
            customerNavbar.Attributes.Add("class", "hidden");
            adminNavbar.Attributes.Add("class", "hidden");
            guestNavbar.Attributes.Add("class", "hidden");
            string classes = "";
            switch (nav)
            {
                case "Customer":
                    classes = customerNavbar.Attributes["class"];
                    classes = classes.Replace("hidden", "");
                    customerNavbar.Attributes["class"] = classes;
                    break;
                case "Admin":
                    classes = adminNavbar.Attributes["class"];
                    classes = classes.Replace("hidden", "");
                    adminNavbar.Attributes["class"] = classes;
                    break;
                case "Guest":
                    classes = guestNavbar.Attributes["class"];
                    classes = classes.Replace("hidden", "");
                    guestNavbar.Attributes["class"] = classes;
                    break;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            customerNavbar = (HtmlGenericControl)FindControl("customerNavbar");
            adminNavbar = (HtmlGenericControl)FindControl("adminNavbar");
            guestNavbar = (HtmlGenericControl)FindControl("guestNavbar");

            var CookiesAuth = Request.Cookies["userAuth"];
            var SessionAuth = Session["role"];
            if (SessionAuth == null && CookiesAuth == null)
            {
                showNavbar("Guest");
            }
            else if (CookiesAuth != null)
            {
                var CookiesRole = CookiesAuth["role"];
                if (CookiesRole == "ADMN")
                {
                    showNavbar("Admin");
                }
                else
                {
                    showNavbar("Customer");
                }
            }
            else
            {
                var sessionAuthRole = SessionAuth.ToString();
                if (sessionAuthRole == "ADMN")
                {
                    showNavbar("Admin");
                 }
                else{
                    showNavbar("Customer");
                }                
            }

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            Response.Redirect(Route.Login);
        }

        protected void Register_Click(object sender, EventArgs e)
        {
            Response.Redirect(Route.Register);
        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            var CookiesAuth = Request.Cookies["userAuth"];
            var SessionRole = Session["role"];
            var SessionUser = Session["userAuth"];
            if(CookiesAuth!=null)
            {
                Response.Cookies["userAuth"].Expires = DateTime.Now.AddDays(-1);
            }
            if(SessionRole!=null || SessionUser!=null)
            {
                Session.Clear();
            }
            Response.Redirect(Route.Home);
        }
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
        protected void CartBtn_Click(object sender, EventArgs e)
        {
            int id = getCurrentUserID();
            Response.Redirect(Route.Cart + "?ID=" + id);
            Response.Redirect(Route.Home);
        }
    }
}