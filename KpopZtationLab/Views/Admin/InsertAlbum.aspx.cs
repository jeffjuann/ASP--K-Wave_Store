using KpopZtationLab.Controllers;
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
    public partial class InsertAlbum : System.Web.UI.Page
    {
        protected Artist artist = new Artist();
        protected int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            bool success = int.TryParse(Request.QueryString["ID"], out id);
            if (!success)
            {
                Response.Redirect(Routes.Route.Home);
            }   
            artist = ArtistController.Get_Artist_By_ID(id);
            
        }

        protected void createAlbum_Click(object sender, EventArgs e)
        {
            //validate
            //render error if there is
            //use controller
            var AlbumName = AlbumNameTxt.Text;
            var AlbumImage = ArtistController.Save_Image(ArtistImageUpload);
            var AlbumDescription = AlbumDescriptionTxt.Text;
            int AlbumPrice = int.Parse(AlbumPriceTxt.Text);
            int AlbumStock = int.Parse(AlbumStockTxt.Text);
            string err = AlbumController.Create_Album(id,AlbumName,AlbumImage,AlbumPrice,AlbumStock,AlbumDescription);

            if (err != null)
            {
                errLbl.Text = err;
                return;
            }
        }
    }
}