using KpopZtationLab.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtationLab.Views.Common
{
    public partial class Registerpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register_Click(object sender, EventArgs e)
        {
            string email = EmailTxt.Text;
            string name = NameTxt.Text;
            string gender = GenderRB.SelectedValue;
            string address = AddressTxt.Text;
            string password = PasswordTxt.Text;
            ErrorLbl.Visible = false;
            string err = RegistrationController.Validate(email,name,gender, address,password);
            if (err == "")
            {
                RegistrationController.Register(email, name, gender, address, password);
            }
            ErrorLbl.Text = err;
            ErrorLbl.Visible = true;
        }
    }
}