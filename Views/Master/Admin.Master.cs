using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDLabProject.Views.Master
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void HomeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/JewelPages/JewelViewer.aspx");

        }

        protected void AddJewelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/JewelPages/Admin/AddJewel.aspx");
        }

        protected void ReportButton_Click(object sender, EventArgs e)
        {

        }

        protected void HandleOrdersButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/JewelPages/Admin/HandleOrder.aspx");

        }

        protected void ProfileButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/JewelPages/Admin/Profile.aspx");
        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Logout.aspx");
        }
    }
}