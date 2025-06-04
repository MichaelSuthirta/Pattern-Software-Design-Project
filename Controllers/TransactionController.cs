using PSDLabProject.Handlers;
using PSDLabProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDLabProject.Controllers
{
    public class TransactionController
    {
        public static List<TransactionHeader> GetUnfinishedTransactions()
        {
            return Handler.GetUnfinishedTransactions();
        }

        public static void HandleAction(int transactionId, string status)
        {
            Handler.HandleAction(transactionId, status);
        }
    }
}