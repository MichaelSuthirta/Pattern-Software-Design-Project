using PSDLabProject.Controllers;
using PSDLabProject.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDLabProject.Views.JewelPages
{
    public partial class JewelViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null || Session["role"] == null)
            {
                Response.Redirect("~/Views/LoginRegisterPages/LoginPage.aspx");
                return;
            }

            if (!IsPostBack)
            {
                UserJewelGridview.DataSource = Handler.getJewelList();
                UserJewelGridview.DataBind();
            }
        }

        protected void detailButton_Command(object sender, CommandEventArgs e)
        {
            string role = Session["role"]?.ToString();
            if (role != "User" && role != "Admin")
            {
                errorMsg.Text = "Unauthorized access.";
                return;
            }

            int ID = Convert.ToInt32(e.CommandArgument);
            string url = JewelController.accessDetailPage(ID);
            if (url == "Not found.")
            {
                errorMsg.Text = "Unable to view details";
            }
            else
            {
                Response.Redirect(".\\" + url);
            }
        }
    }
}