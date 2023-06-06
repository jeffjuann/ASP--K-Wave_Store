using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtationLab.Routes
{
    public class Route
    {
        public static string Home { get; private set; } = "~/Views/Common/Homepage.aspx";
        public static string Login { get; private set; } = "~/Views/Common/Loginpage.aspx";

        public static string Register { get; private set; } = "~/Views/Common/Registerpage.aspx";

        public static string TransactionReport { get; private set; } = "~/Views/Admin/TransactionReportpage.aspx";

        public static string Cart { get; private set; } = "~/Views/Customer/Cartpage.aspx";

        public static string TransactionHistory { get; private set; } = "~/Views/Customer/TransactionHistory.aspx";

        public static string UpdateArtist { get; private set; } = "~/Views/Admin/UpdateArtists.aspx";
        public static string ArtistDetail { get; private set; } = "~/Views/Common/ArtistDetail.aspx";
        public static string InsertAlbum { get; private set; } = "~/Views/Admin/InsertAlbum.aspx";
        public static string UpdateAlbum { get; private set; } = "~/Views/Admin/UpdateAlbum.aspx";

        public static string InsertArtist { get; private set; } = "~/Views/Admin/InsertArtists.aspx";
        public static string AlbumDetail { get; private set; } = "~/Views/Common/AlbumDetail.aspx";

    }
}