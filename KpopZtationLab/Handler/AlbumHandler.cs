using KpopZtationLab.Models;
using KpopZtationLab.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtationLab.Handler
{
    public class AlbumHandler
    {
        public static void Add(Album albumTobeAdded)
        {
            repo.albums.Add(albumTobeAdded);
        }
    }
}