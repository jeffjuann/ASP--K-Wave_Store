using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

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
                case "Admin":
                    classes = customerNavbar.Attributes["class"];
                    classes = classes.Replace("hidden", "");
                    customerNavbar.Attributes["class"] = classes;
                    break;
                case "Customer":
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
                if (CookiesRole == "Admin")
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
                if (sessionAuthRole == "Admin"){
                    showNavbar("Admin");
                 }
                else{
                    showNavbar("Customer");
                }                
            }

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            Response.Redirect(Routes.Route.Login);
        }

        protected void Register_Click(object sender, EventArgs e)
        {
            Response.Redirect(Routes.Route.Register);
        }
    }
}