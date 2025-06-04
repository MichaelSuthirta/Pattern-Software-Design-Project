using PSDLabProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace PSDLabProject.Repositories
{
    public class TransactionRepository
    {
        private static DatabaseProjectEntities db = new DatabaseProjectEntities();
        public static List<TransactionHeader> GetUnfinishedTransactions()
        {
            return db.TransactionHeaders
                     .Where(t => t.TransactionStatus != "Done" && t.TransactionStatus != "Rejected")
                     .Include(t => t.MsUser)
                     .ToList();
        }

        public static TransactionHeader GetTransactionById(int id)
        {
            return db.TransactionHeaders.FirstOrDefault(t => t.TransactionID == id);
        }

        public static void UpdateTransactionStatus(int transactionId, string newStatus)
        {
            var transaction = db.TransactionHeaders.FirstOrDefault(t => t.TransactionID == transactionId);
            if (transaction != null)
            {
                transaction.TransactionStatus = newStatus;
                db.SaveChanges();
            }
        }
    }
}