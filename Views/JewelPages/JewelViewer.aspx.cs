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
    public partial class ViewJewels : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserJewelGridview.DataSource = Handler.getJewelList();
            UserJewelGridview.DataBind();
        }

        protected void detailButton_Command(object sender, CommandEventArgs e)
        {
            //errorMsg.Text = "Unable to view details";
            int ID = Convert.ToInt32(e.CommandArgument);
            string url = JewelController.accessDetailPage(ID);
            if (url == "Not found.")
            {
                errorMsg.Text = "Unable to view details";
            }
            else
            {
                Response.Redirect("./" + url);
            }
        }
    }
}