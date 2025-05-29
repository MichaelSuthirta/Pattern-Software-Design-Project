using PSDLabProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDLabProject.Repositories
{
    public class JewelRepository
    {
        private static DatabaseProjectEntities db = new DatabaseProjectEntities();

        public static MsJewel findJewelByID(int jewelID)
        {
            return db.MsJewels.Where(x => x.JewelID == jewelID).FirstOrDefault();
        }
        public static string addJewel(MsJewel jewel)
        {
            db.MsJewels.Add(jewel);
            db.SaveChanges();
            return "Jewel added successfully.";
        }

        public static string deleteJewel(MsJewel jewel)
        {
            db.MsJewels.Remove(jewel);
            db.SaveChanges();
            return "Jewel removed successfully.";
        }
    }
}