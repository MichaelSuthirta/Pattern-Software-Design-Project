using PSDLabProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDLabProject.Handlers
{
    public class LoginHandler
    {
        public string loginUser(string email, string password)
        {
            if (UserRepository.findUserByEmail(email) == null)
            {
                return "Email doesn't exists";
            }
            if (UserRepository.findPasswordByEmail(email) != password)
            {
                return "Password doesn't match";
            }
            return "Logged in successfully";
        }
    }
}