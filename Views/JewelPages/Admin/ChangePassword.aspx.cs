using PSDLabProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDLabProject.Views.JewelPages.Admin
{
	public partial class ChangePassword : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (Session["UserID"] == null)
                Response.Redirect("~/Views/LoginRegisterPages/LoginPage.aspx");
        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            string userId = Session["UserID"].ToString();
            string oldPassword = txtOldPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(oldPassword) || string.IsNullOrWhiteSpace(newPassword))
            {
                lblMessage.Text = "Fields cannot be empty.";
                return;
            }

            if (newPassword.Length < 8 || newPassword.Length > 25 || !newPassword.All(char.IsLetterOrDigit))
            {
                lblMessage.Text = "New password must be alphanumeric and 8–25 characters.";
                return;
            }

            if (newPassword != confirmPassword)
            {
                lblMessage.Text = "New password and confirmation do not match.";
                return;
            }

            using (DatabaseProjectEntities db = new DatabaseProjectEntities())
            {
                int id = int.Parse(userId);
                var user = db.MsUsers.FirstOrDefault(u => u.UserID == id);

                if (user == null)
                {
                    lblMessage.Text = "User not found.";
                    return;
                }

                if (user.UserPassword != oldPassword)
                {
                    lblMessage.Text = "Old password is incorrect.";
                    return;
                }

                user.UserPassword = newPassword;
                db.SaveChanges();

                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Password changed successfully.";
            }
        }
    }
}