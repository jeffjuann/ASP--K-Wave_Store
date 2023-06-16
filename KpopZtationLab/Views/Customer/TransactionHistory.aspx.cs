using KpopZtationLab.Models;
using KpopZtationLab.Pattern;
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
            int id = getCurrentUserID();
            //ini harusnya array
            var transactionDetails = repo.transactionDetails.Find(x => x.TransactionHeader.CustomerID==id).ToList();
            
        }
    }
}