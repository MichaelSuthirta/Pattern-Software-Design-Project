using PSDLabProject.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDLabProject.Views.JewelPages.Admin
{
    public partial class EditJewel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                brandDropdown.DataSource = JewelController.getBrandNames();
                brandDropdown.DataBind();

                categoryDropdown.DataSource = JewelController.getCategoryNames();
                categoryDropdown.DataBind();
            }


        }

        protected void confirmButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            string name = nameText.Text;
            string brand = brandDropdown.SelectedValue;
            string category = categoryDropdown.SelectedValue;
            string priceStr = priceText.Text;
            string yearStr = yearText.Text;
            messageText.Text = JewelController.updateJewelData(id, name, brand, category, priceStr, yearStr);
            if(messageText.Text == "Updated data successfully.")
            {
                Response.Redirect("~\\Views\\JewelPages\\JewelViewer.aspx");
            }
        }
    }
}