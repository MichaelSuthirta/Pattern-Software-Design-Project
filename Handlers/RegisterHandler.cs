using PSDLabProject.Factories;
using PSDLabProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDLabProject.Handlers
{
    public class RegisterHandler
    {
        public string registerUser(string email, string username, string password, DateTime dob, string gender)
        {
            if (UserRepository.findUserByEmail(email) == null)
            {
                return UserRepository.addUser(UserFactory.createUser(username, email, password, dob, gender, "Customer"));
            }
            return "Email is already taken";
        }
    }
}