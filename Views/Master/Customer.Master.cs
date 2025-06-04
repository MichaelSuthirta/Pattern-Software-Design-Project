using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDLabProject.Views.Master
{
    public partial class Customer : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void HomeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/JewelPages/JewelViewer.aspx");
        }

        protected void CartButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/JewelPages/User/Cart.aspx");
        }

        protected void OrderButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/JewelPages/User/Details.aspx");
        }

        protected void ProfileButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/JewelPages/User/Profile.aspx");
        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Logout.aspx");
        }
    }
}