using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtationLab.Views.Pages
{
    public partial class TransactionHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["userAuth"] == null || Request.Cookies["userAuth"] == null)
                {
                    Response.Redirect(Routes.Route.Login);
                    return;
                }
            }
        }
    }
}