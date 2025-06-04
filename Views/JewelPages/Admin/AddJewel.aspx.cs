using PSDLabProject.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDLabProject.Views.JewelPages.Admin
{
    public partial class AddJewel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                categoryDropdown.DataSource = JewelController.getCategoryNames();
                categoryDropdown.DataBind();

                brandDropdown.DataSource = JewelController.getBrandNames();
                brandDropdown.DataBind();
            }

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            string name = nameText.Text;
            string category = categoryDropdown.SelectedValue;
            string brand = brandDropdown.SelectedValue;
            string priceStr = priceText.Text;
            string yearStr = yearText.Text;
            string result = JewelController.addJewel(name, brand, category, priceStr, yearStr);
            if (result.Equals("Jewel added successfully."))
            {
                Response.Redirect("~\\Views\\JewelPages\\JewelViewer.aspx");
            }
            else
            {
                messageText.Text = result;
            }
        }
    }
}