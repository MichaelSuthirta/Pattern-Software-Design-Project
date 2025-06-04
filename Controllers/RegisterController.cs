using PSDLabProject.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace PSDLabProject.Controllers
{
    public class RegisterController
    {
        private RegisterHandler registerHandler = new RegisterHandler();
        public string registerUser(string email, string username, string password,
                                string confirmPassword, DateTime dateTime, bool isMale, bool isFemale)
        {

            string userGender;

            if (!isValidEmail(email)) { return "Email isn't valid"; }
            if (username.Length < 3 || username.Length > 25) { return "Username should be between 3 - 25 characters"; }
            if (!isValidPassword(password)) { return "Password should be alphanumeric and between 8 - 20 characters"; }
            if (password != confirmPassword) { return "Password doesn't match"; }
            if (!isMale && !isFemale) { return "Please choose gender"; }
            if (dateTime == DateTime.MinValue) { return "Please pick your date of birth"; }
            if (dateTime >= new DateTime(2010, 1, 1)) { return "Date of Birth must be earlier than 01/01/2010"; }
            if (isMale) userGender = "Male"; else userGender = "Female";
            return registerHandler.registerUser(email, username, password, dateTime, userGender);
        }
        private bool isValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        private bool isValidPassword(string password)
        {
            string pattern = @"^[a-zA-Z0-9]{8,20}$";
            return Regex.IsMatch(password, pattern);
        }
    }
}