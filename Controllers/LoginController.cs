using PSDLabProject.Handlers;
using PSDLabProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDLabProject.Controllers
{
    public class LoginController
    {
        private LoginHandler loginHandler = new LoginHandler();
        public string loginUser(string email, string password)
        {
            if (email == null) { return "Please insert email"; }
            if (password == null) { return "Please insert password"; }
            return loginHandler.loginUser(email, password);
        }

        public MsUser userEmail(string email)
        {
            return loginHandler.userEmail(email);
        }
    }
}