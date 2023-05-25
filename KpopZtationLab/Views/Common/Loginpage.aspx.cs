using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KpopZtationLab.Controllers;
using KpopZtationLab.Models;
using KpopZtationLab.Routes;
namespace KpopZtationLab.Views.Common
{
    public partial class Loginpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void AssignCookies(Customer user)
        {
            HttpCookie cookie = new HttpCookie("userAuth");
            cookie["id"] = user.CustomerID.ToString();
            cookie["role"] = user.CustomerRole;
            cookie.Expires = DateTime.Now.AddMinutes(60);
            Response.Cookies.Add(cookie);
        }
        protected void AssignSession(Customer user)
        {
            Session["userAuth"] = user.CustomerID.ToString();
            Session["role"] = user.CustomerRole;
        }
        protected void Login_Click(object sender, EventArgs e)
        {
            var isRemember = RememberMeChk.Checked;
            var email = EmailTxt.Text;
            var password = PasswordTxt.Text;
            ErrorLbl.Visible = false;
            var user = AuthenticationController.Authenticate(email, password);
            if (user != null)
            {
                if (isRemember)
                {
                    AssignCookies(user);
                }
                AssignSession(user);
                Response.Redirect(Route.Home);
            }
            ErrorLbl.Visible = true;
        }
    }
}