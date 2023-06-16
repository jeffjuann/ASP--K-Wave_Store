using KpopZtationLab.Controllers;
using KpopZtationLab.Factory;
using KpopZtationLab.Models;
using KpopZtationLab.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtationLab.Views.Admin
{
    public partial class UpdateArtists : System.Web.UI.Page
    {
        protected Artist artist;
        protected int id;
        protected void Page_Load(object sender, EventArgs e)
        {

            bool success = int.TryParse(Request.QueryString["ID"], out id);
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            errLbl.Visible = false;
            string err = ArtistController.Validate(ArtistTxt.Text, ArtistImageUpload);
            if (err != "")
            {
                errLbl.Text = err;
                errLbl.Visible = true;
                return;
            }
            var image = ArtistController.Save_Image(ArtistImageUpload);
            ArtistController.Update(id, ArtistTxt.Text, image);
            Response.Redirect(Routes.Route.Home);
            //errLbl.Visible = true;
            //errLbl.Text = repo.artists.Find(x => x.ArtistName == name).Count().ToString();
        }
    }
}