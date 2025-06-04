using PSDLabProject.Handlers;
using PSDLabProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Services.Protocols;

namespace PSDLabProject.Controllers
{
    public class JewelController
    {
        public static bool jewelExists(int ID)
        {
            return Handler.jewelExists(ID);
        }

        public static string accessDetailPage(int jewelID, string role)
        {
            if (!jewelExists(jewelID))
            {
                return "Not found";
            }
            if (role.Equals("Customer"))
            {
                return "User\\Details.aspx?id=" + jewelID.ToString();
            }
            else if(role.Equals("Admin"))
            {
                return "Admin\\Details.aspx?id=" + jewelID.ToString();
            }
            else
            {
                return "Unauthorized access.";
            }
        }

        public static MsJewel getJewel(int ID)
        {
            if (!jewelExists(ID))
            {
                return null;
            }
            return Handler.findJewelByID(ID);
        }

        public static MsBrand getJewelBrand(int jewelID)
        {
            return Handler.getJewelBrand(jewelID);
        }

        public static MsCategory getJewelCategory(int jewelID)
        {
            return Handler.getJewelCategory(jewelID);
        }

        public static List<string> getBrandNames()
        {
            return Handler.getBrandNames();
        }

        public static List<string> getCategoryNames()
        {
            return Handler.getCategoryNames();
        }

        private static bool correctLength(string str, int minLength, int maxLength)
        {
            if(str.Length < minLength || str.Length > maxLength)
            {
                return false;
            }
            return true;
        }

        private static bool correctJewelNameLength(string name)
        {
            if(!correctLength(name, 3, 25)){
                return false;
            }
            return true;
        }

        private static string validateJewelInput(string name, string brand, string category, string priceStr, string yearStr)
        {
            if (!correctJewelNameLength(name))
            {
                return "Name length must be between 3 and 25";
            }
            if (!int.TryParse(priceStr, out int price))
            {
                return "Price must be a number";
            }
            if (!int.TryParse(yearStr, out int year))
            {
                return "Year must be a number";
            }
            if (price <= 25)
            {
                return "Price must be above $25";
            }
            if (year < 2025)
            {
                return "Invalid year, must be above the current year";
            }
            return "Valid";
        }

        public static string addJewel(string name, string brand, string category, string priceStr, string yearStr)
        {
            string validateResult = validateJewelInput(name, brand, category, priceStr, yearStr);
            if (!validateResult.Equals("Valid"))
            {
                return validateResult;
            }
            int.TryParse(priceStr, out int price);
            int.TryParse(yearStr, out int year);
            return Handler.addJewel(name, brand, category, price, year);
        }

        public static string updateJewelData(int id, string name, string brand, string category, string priceStr, string yearStr)
        {
            if (!jewelExists(id))
            {
                return "Jewel cannot be found";
            }
            string validateResult = validateJewelInput(name, brand, category, priceStr, yearStr);
            if (!validateResult.Equals("Valid"))
            {
                return validateResult;
            }
            int.TryParse(priceStr, out int price);
            int.TryParse(yearStr, out int year);
            return Handler.updateJewelData(id, name, brand, category, price, year);
        }

        public static string deleteJewel(int jewelID)
        {
            if (!jewelExists(jewelID))
            {
                return "Jewel cannot be found.";
            }
            return Handler.deleteJewel(jewelID);
        }
    }
}