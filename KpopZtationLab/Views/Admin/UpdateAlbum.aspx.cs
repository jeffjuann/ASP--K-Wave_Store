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
    public partial class UpdateAlbum : System.Web.UI.Page
    {
        protected Album album;
        protected int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            bool success = int.TryParse(Request.QueryString["ID"], out id);
            if (success)
            {
                album = AlbumController.Get_album_by_id(id);
            }
        }

        protected void updateAlbum_Click(object sender, EventArgs e)
        {
            var AlbumName = AlbumNameTxt.Text;
            var AlbumDescription = AlbumDescriptionTxt.Text;
            var AlbumPrice = int.Parse(AlbumPriceTxt.Text);
            var AlbumStock = int.Parse(AlbumStockTxt.Text);
            string err = AlbumController.Validate(AlbumName, AlbumDescription, AlbumPrice, AlbumStock, AlbumImageUpload);
            if (err != "")
            {
                errLbl.Text = err;
                errLbl.Visible = true;
                return;
            }
            var AlbumImage = AlbumController.Save_Image(AlbumImageUpload);
            AlbumController.Update(id, AlbumName, AlbumImage, AlbumDescription, AlbumPrice, AlbumStock);
        }
    }
}