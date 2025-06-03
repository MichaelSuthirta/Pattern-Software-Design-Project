using PSDLabProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDLabProject.Factories
{
    public class CartFactory
    {
        public static Cart createNewCart(int jewelID, int userID, int qty)
        {
            return new Cart()
            {
                JewelID = jewelID,
                UserID = userID,
                Quantity = qty
            };
        }
    }
}