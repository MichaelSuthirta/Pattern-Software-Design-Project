using PSDLabProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDLabProject.Repositories
{
    public class CartRepository
    {
        private static DatabaseProjectEntities db = new DatabaseProjectEntities();

        public class CartItemView
        {
            public int JewelID { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string Brand { get; set; }
            public int Quantity { get; set; }
            public decimal Subtotal { get; set; }
        }

        public static List<CartItemView> GetCartItems(int userId)
        {
            return db.Carts
                .Where(c => c.UserID == userId)
                .Select(c => new CartItemView
                {
                    JewelID = c.JewelID,
                    Name = c.MsJewel.JewelName,
                    Price = c.MsJewel.JewelPrice,
                    Brand = c.MsJewel.MsBrand.BrandName,
                    Quantity = c.Quantity,
                    Subtotal = c.Quantity * c.MsJewel.JewelPrice
                }).ToList();
        }


        public static void UpdateCartItem(int userId, int jewelId, int quantity)
        {
            var item = db.Carts.FirstOrDefault(c => c.MsUser.UserID == userId && c.JewelID == jewelId);
            if (item != null)
            {
                item.Quantity = quantity;
                db.SaveChanges();
            }
        }

        public static void RemoveCartItem(int userId, int jewelId)
        {
            var item = db.Carts.FirstOrDefault(c => c.UserID == userId && c.JewelID == jewelId);
            if (item != null)
            {
                db.Carts.Remove(item);
                db.SaveChanges();
            }
        }

        public static void ClearCart(int userId)
        {
            var items = db.Carts.Where(c => c.UserID == userId).ToList();
            db.Carts.RemoveRange(items);
            db.SaveChanges();
        }

        public static int CreateTransactionHeader(int userId, string paymentMethod)
        {
            var header = new TransactionHeader
            {
                UserID = userId,
                PaymentMethod = paymentMethod,
                TransactionDate = DateTime.Now,
                TransactionStatus = "Payment Pending"
            };
            db.TransactionHeaders.Add(header);
            db.SaveChanges();
            return header.TransactionID;
        }

        public static void CreateTransactionDetail(int headerId, CartItemView item)
        {
            var detail = new TransactionDetail
            {
                TransactionID = headerId,
                JewelID = item.JewelID,
                Quantity = item.Quantity
            };
            db.TransactionDetails.Add(detail);
            db.SaveChanges();
        }
    }

}