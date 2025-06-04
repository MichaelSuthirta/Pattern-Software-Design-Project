using PSDLabProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDLabProject.Views.JewelPages.Admin
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }

            if (!IsPostBack)
            {
                int userId = (int)Session["UserId"];
                using (var db = new DatabaseProjectEntities())
                {
                    var user = db.MsUsers.FirstOrDefault(u => u.UserID == userId);
                    if (user != null)
                    {
                        lblEmailValue.Text = user.UserEmail;
                        lblUsernameValue.Text = user.UserName;
                        lblGenderValue.Text = user.UserGender;
                        lblDOBValue.Text = user.UserDOB.ToString("yyyy-MM-dd");
                    }
                }
            }
        }

        protected void btnRedirectChangePassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/JewelPages/Admin/ChangePassword.aspx");
        }
    }
}