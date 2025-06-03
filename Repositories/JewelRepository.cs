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

        public static List<MsJewel> getJewelList()
        {
            return db.MsJewels.ToList();
        }
        public static List<string> getBrandNames()
        {
            return db.MsBrands.Select(x => x.BrandName).ToList();
        }
        public static List<string> getCategoryNames()
        {
            return db.MsCategories.Select(x => x.CategoryName).ToList();
        }
        public static int getBrandID(string brandName)
        {
            return db.MsBrands.Where(x => x.BrandName == brandName).Select(x => x.BrandID).FirstOrDefault();
        }
        public static int getCategoryID(string categoryName)
        {
            return db.MsCategories.Where(x => x.CategoryName == categoryName).Select(x => x.CategoryID).FirstOrDefault();
        }
        public static string updateJewelData(int id, string name, int brandID, int categoryID, int price, int year)
        {
            MsJewel jewel = findJewelByID(id);

            jewel.JewelName = name;
            jewel.JewelPrice = price;
            jewel.JewelReleaseYear = year;
            jewel.BrandID = brandID;
            jewel.CategoryID = categoryID;
            db.SaveChanges();
            return "Updated data successfully.";
        }
    }
}