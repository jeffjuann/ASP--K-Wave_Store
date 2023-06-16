using KpopZtationLab.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtationLab.Views.Customer
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = getCurrentUserID();
                var user = CustomerController.getUserByID(id);
                EmailTxt.Text = user.CustomerEmail;
                NameTxt.Text = user.CustomerName;
                AddressTxt.Text = user.CustomerAddress;
                PasswordTxt.Text = user.CustomerPassword;
                GenderRB.SelectedValue = user.CustomerGender;
                ErrorLbl.Visible = false;
            }
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
        protected void Save_Click(object sender, EventArgs e)
        {
            string email = EmailTxt.Text;
            string name = NameTxt.Text;
            string gender = GenderRB.SelectedValue;
            string address = AddressTxt.Text;
            string password = PasswordTxt.Text;
            ErrorLbl.Visible = false;
            string err = CustomerController.Validate(email, name, gender, address, password);
            if (err!="")
            {
                ErrorLbl.Text = err;
                ErrorLbl.Visible = true;
                return;
            }
            int id = getCurrentUserID();
            CustomerController.Update(id, email, name, gender, address, password);
        }
    }
}