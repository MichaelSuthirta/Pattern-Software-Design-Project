using PSDLabProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDLabProject.Factories
{
    public class HeaderFactory
    {
        public static TransactionHeader createHeader(int userID, DateTime date, string paymentMethod, string status)
        {
            return new TransactionHeader()
            {
                UserID = userID,
                TransactionDate = date,
                PaymentMethod = paymentMethod,
                TransactionStatus = status
            };
        }
    }
}