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
        public static MsBrand findBrandByID(int brandID)
        {
            return db.MsBrands.Where(x => x.BrandID == brandID).FirstOrDefault();
        }
        public static MsCategory findCategoryByID(int categoryID)
        {
            return db.MsCategories.Where(x => x.CategoryID == categoryID).FirstOrDefault();
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

        public static List<dynamic> getAllJewels()
        {
            return (from j in db.MsJewels
                    join c in db.MsCategories
                    on j.CategoryID equals c.CategoryID
                    join b in db.MsBrands on j.BrandID equals b.BrandID
                    select new {j.JewelName, c.CategoryName, b.BrandName,
                    b.BrandCountry, b.BrandClass, j.JewelPrice, j.JewelReleaseYear}).ToList<dynamic>();
        }
    }
}