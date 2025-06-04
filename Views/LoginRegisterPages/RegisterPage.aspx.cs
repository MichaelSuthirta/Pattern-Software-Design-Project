using Microsoft.Win32;
using PSDLabProject.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDLabProject.Views.LoginRegisterPages
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        private RegisterController register = new RegisterController();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            string email = EmailTextBox.Text;
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            string confirmPassword = ConfirmPasswordTextBox.Text;
            DateTime dateTime = Calendar1.SelectedDate;
            bool isMale = maleRadioButton.Checked;
            bool isFemale = femaleRadioButton.Checked;

            string message = register.registerUser(email, username, password,
                                confirmPassword, dateTime, isMale, isFemale);

            if (message == "User added successfully")
            {
                Response.Redirect("LoginPage.aspx");
            }
            else
            {
                MessageLabel.Text = message;
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime dateTime = Calendar1.SelectedDate;
            CalendarTextBox.Text = dateTime.ToString("dd-MM-yyyy");
        }
    }
}