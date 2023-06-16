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
            if (success)
            {
                artist = repo.artists.Find(x => x.ArtistID == id).FirstOrDefault();
                ArtistTxt.Text = artist.ArtistName;
            }
            
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            var name = ArtistTxt.Text;
            errLbl.Visible = false;
            if (!ArtistController.Artist_IsUnique(name))
            {
                errLbl.Visible = true;
                errLbl.Text = "artist is not unique";
                return;

            };
            if (
                !ArtistController.Image_Less_Than_2mb(ArtistImg)
                && ArtistController.file_IsImageExtension(ArtistImg))
            {
                errLbl.Visible = true;
                errLbl.Text = "File must be less than 2mb and an image type";
                return;
            };
            var image = ArtistController.Save_Image(ArtistImg);
            ArtistController.Update(id,name, image);
        }
    }
}