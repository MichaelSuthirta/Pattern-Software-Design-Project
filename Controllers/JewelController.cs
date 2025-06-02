using PSDLabProject.Handlers;
using PSDLabProject.Models;
using System;
using System.Collections.Generic;
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

        public static string accessDetailPage(int jewelID)
        {
            if (!jewelExists(jewelID))
            {
                return "Not found";
            }
            
            return "User/Details.aspx?id=" + jewelID.ToString();
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
    }
}