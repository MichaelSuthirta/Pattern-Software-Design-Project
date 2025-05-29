using PSDLabProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDLabProject.Factories
{
    public class TransactionDetailsFactory
    {
        public static TransactionDetail createDetails(int transactionID, int jewelID, int quantity)
        {
            return new TransactionDetail()
            {
                TransactionID = transactionID,
                JewelID = jewelID,
                Quantity = quantity
            };
        }
    }
}