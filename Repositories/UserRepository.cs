using PSDLabProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDLabProject.Repositories
{
    public class UserRepository
    {
        private static DatabaseProjectEntities db = new DatabaseProjectEntities();

        public static MsUser findUserByEmail(string email)
        {
            return db.MsUsers.Where(x => x.UserEmail == email).FirstOrDefault();
        }
        public static string findPasswordByEmail(string email)
        {
            return db.MsUsers.Where(x => x.UserEmail == email)
                             .Select(x => x.UserPassword)
                             .FirstOrDefault();
        }
        public static string findRoleByEmail(string email)
        {
            return db.MsUsers.Where(x => x.UserEmail == email)
                             .Select(x => x.UserRole)
                             .FirstOrDefault();
        }

        public static string addUser(MsUser user)
        {
            db.MsUsers.Add(user);
            db.SaveChanges();
            return "User added successfully";
        }
    }
}