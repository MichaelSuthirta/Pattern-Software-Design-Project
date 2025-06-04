using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDLabProject.Views
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();

            if (Request.Cookies["UserLogin"] != null)
            {
                HttpCookie cookie = new HttpCookie("UserLogin");
                cookie.Expires = DateTime.Now.AddDays(-1); // kadaluwarsa langsung
                Response.Cookies.Add(cookie);
            }

            Response.Redirect("~/Views/LoginRegisterPages/LoginPage.aspx");
        }
    }
}