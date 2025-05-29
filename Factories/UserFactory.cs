using PSDLabProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDLabProject.Factories
{
    public class UserFactory
    {
        public static MsUser createUser(string name, string email, string password, DateTime dob, string gender, string role)
        {
            return new MsUser()
            {
                UserName = name,
                UserEmail = email,
                UserPassword = password,
                UserDOB = dob,
                UserGender = gender,
                UserRole = role
            };
        }
    }
}