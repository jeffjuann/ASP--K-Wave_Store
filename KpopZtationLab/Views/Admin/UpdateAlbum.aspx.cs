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
                album = repo.albums.Find(x => x.AlbumID == id).FirstOrDefault();
                AlbumNameTxt.Text = album.AlbumName;
                AlbumDescriptionTxt.Text = album.AlbumDescription;
                AlbumPriceTxt.Text = album.AlbumPrice.ToString();
                AlbumStockTxt.Text = album.AlbumStock.ToString();
            }
        }

        protected void updateAlbum_Click(object sender, EventArgs e)
        {
            //var AlbumName = AlbumNameTxt.Text;
            //var AlbumImage = ArtistImageUpload.
            //var AlbumDescription = AlbumDescriptionTxt.Text;
            //var AlbumPrice = int.Parse(AlbumPriceTxt.Text);
            //var AlbumStock = int.Parse(AlbumStockTxt.Text);

            //AlbumController.Update(album.AlbumID, AlbumName, AlbumImage,AlbumDescription, AlbumPrice, AlbumStock);
        }
    }
}