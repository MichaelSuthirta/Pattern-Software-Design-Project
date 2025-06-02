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
            UserJewelGridview.DataSource = Handler.getAllJewelList();
            UserJewelGridview.DataBind();
        }
    }
}