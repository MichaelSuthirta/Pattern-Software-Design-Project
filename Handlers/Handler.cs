using PSDLabProject.Models;
using PSDLabProject.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Web;

namespace PSDLabProject.Handlers
{
    public class Handler
    {
        public static List<MsJewel> getJewelList()
        {
            return JewelRepository.getJewelList();
        }
        public static List<string> getBrandNames()
        {
            return JewelRepository.getBrandNames();
        }
        public static List<string> getCategoryNames()
        {
            return JewelRepository.getCategoryNames();
        }

        public static bool jewelExists(int ID)
        {
            if (JewelRepository.findJewelByID(ID) == null)
            {
                return false;
            }
            return true;
        }

        public static MsJewel findJewelByID(int ID)
        {
            return JewelRepository.findJewelByID(ID);
        }

        public static MsCategory findCategoryByID(int ID)
        {
            return JewelRepository.findCategoryByID(ID);
        }

        public static MsBrand findBrandByID(int ID)
        {
            return JewelRepository.findBrandByID(ID);
        }

        public static string getJewelName(int ID)
        {
            return (findJewelByID(ID)).JewelName;
        }

        public static MsBrand getJewelBrand(int jewelID)
        {
            MsJewel jewel = findJewelByID(jewelID);
            if(jewel == null)
            {
                return null;
            }
            return findBrandByID(jewel.BrandID);
        }

        public static MsCategory getJewelCategory(int jewelID)
        {
            MsJewel jewel = findJewelByID(jewelID);
            if (jewel == null)
            {
                return null;
            }
            return findCategoryByID(jewel.CategoryID);
        }

        private static int getBrandID(string brandName)
        {
            return JewelRepository.getBrandID(brandName);
        }
        private static int getCategoryID(string categoryName)
        {
            return JewelRepository.getCategoryID(categoryName);
        }
        public static string updateJewelData(int id, string name, string brand, string category, int price, int year)
        {
            int brandID = getBrandID(brand);
            int categoryID = getCategoryID(category);
            return JewelRepository.updateJewelData(id, name, brandID, categoryID, price, year);
        }
    }
}