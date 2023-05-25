using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtationLab.Models;
namespace KpopZtationLab.Pattern
{
    public class Database
    {
        private static KpopZtationDBEntities db;
        public static KpopZtationDBEntities getConnection()
        {
            if(db==null)    
                return db = new KpopZtationDBEntities();
            return db;
        }

        public static KpopZtationDBEntities Connection
        {
            get
            {
                if (db == null)
                {
                    return db = new KpopZtationDBEntities();
                }
                return db;
            }
        }
    }
}