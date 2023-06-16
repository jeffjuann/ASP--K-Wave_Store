using KpopZtationLab.Controllers;
using KpopZtationLab.Models;
using System;
using System.Collections.Generic;
using KpopZtationLab.Pattern;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KpopZtationLab.Factory;
using System.IO;

namespace KpopZtationLab.Views.Admin
{
    public partial class InsertArtists : System.Web.UI.Page
    {
        protected List<Artist> artists = new List<Artist>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //int id;

                //bool success = int.TryParse(Request.QueryString["ID"],out id);
                //if (success)
                //{

                //}

                artists = ArtistController.Get_All_Artist();
            }
        }

        protected void Insert_Click(object sender, EventArgs e)
        {
            var name = ArtistTxt.Text;
            errLbl.Visible = false;
            string err = ArtistController.Validate(name, ArtistImageUpload);
            if(err!="")
            {
                errLbl.Text = err;
                errLbl.Visible = true;
                return;
            }
            var image = ArtistController.Save_Image(ArtistImageUpload);
            var artist = ArtistFactory.Create(name, image);
            repo.artists.Add(artist);
            artists = ArtistController.Get_All_Artist();
        }
    }
}