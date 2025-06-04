using PSDLabProject.Controllers;
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
            //    if (Request.Cookies["user"] != null)
            //    {
            //        HttpCookie cookie = Request.Cookies["user"];

            //        if (int.TryParse(cookie["id"], out int id))
            //        {
            //            Response.Redirect("LoginPage.aspx");
            //        }

            //        users user = db.users.Find(id);

            //        if (user == null) return;

            //        Session["user"] = user;
            //    }

            //    if (Session["user"] != null)
            //    {
            //        Response.Redirect("HomePage.aspx");
            //    }
            //}
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
                //Session["user"] = User
                Response.Redirect("~/Views/JewelPages/JewelViewer.aspx");
            }
        }
    }
}