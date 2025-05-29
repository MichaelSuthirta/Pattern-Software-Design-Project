using PSDLabProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDLabProject.Factories
{
    public class JewelFactory
    {
        public static MsJewel createJewel(int brandID, int categoryID, string name, int price, int releaseYear)
        {
            return new MsJewel()
            {
                BrandID = brandID,
                CategoryID = categoryID,
                JewelName = name,
                JewelPrice = price,
                JewelReleaseYear = releaseYear
            };
        }
    }
}