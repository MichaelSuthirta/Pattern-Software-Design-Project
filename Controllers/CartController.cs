using PSDLabProject.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDLabProject.Controllers
{
    public class CartController
    {
        public static string createCart(int jewelID, int userID, int qty)
        {
            if (!Handler.jewelExists(jewelID))
            {
                return "Jewel cannot be added because it isn't found";
            }
            if (qty < 0)
            {
                return "Quantity cannot be below 0";
            }
            return Handler.createCart(userID, jewelID, qty);
        }
    }
}