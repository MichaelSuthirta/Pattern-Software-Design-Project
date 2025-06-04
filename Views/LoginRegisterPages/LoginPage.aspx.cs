using PSDLabProject.Controllers;
using PSDLabProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDLabProject.Views.LoginRegisterPages
{
    public partial class LoginPage : System.Web.UI.Page
    {
        private LoginController login = new LoginController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie cookie = Request.Cookies["UserLogin"];
                if (cookie != null)
                {
                    string email = cookie["email"];
                    MsUser user = login.userEmail(email);
                    if (user != null)
                    {
                        Session["user"] = user;
                        Session["role"] = user.UserRole;
                        Response.Redirect("~/Views/JewelPages/JewelViewer.aspx");
                    }
                }
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;

            string message = login.loginUser(email, password);
            if (message == "Email doesn't exists") { MessageLabel.Text = message; }
            if (message == "Password doesn't match") { MessageLabel.Text = message; }
            if (message == "Logged in successfully")
            {
                MsUser user = login.userEmail(email);
                Session["user"] = user;
                Session["role"] = user.UserRole;

                if (RememberMeCheckbox.Checked)
                {
                    HttpCookie cookie = new HttpCookie("UserLogin");
                    cookie["email"] = user.UserEmail;
                    cookie.Expires = DateTime.Now.AddDays(7);
                    Response.Cookies.Add(cookie);
                }

                Response.Redirect("~/Views/JewelPages/JewelViewer.aspx");
            }
        }
    }
}