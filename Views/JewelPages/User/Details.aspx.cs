using PSDLabProject.Controllers;
using PSDLabProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDLabProject.Views.JewelPages.User
{
    public partial class Details : System.Web.UI.Page
    {
        private void fillDetails(MsJewel jewel, MsBrand brand, MsCategory category)
        {
            nameLabel.Text = jewel.JewelName;
            categoryLabel.Text = category.CategoryName;
            brandLabel.Text = brand.BrandName;
            countryLabel.Text = brand.BrandCountry;
            classLabel.Text = brand.BrandClass;
            priceLabel.Text = jewel.JewelPrice.ToString();
            yearLabel.Text = jewel.JewelReleaseYear.ToString();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            MsJewel jewel = JewelController.getJewel(id);
            MsBrand brand = JewelController.getJewelBrand(id);
            MsCategory category = JewelController.getJewelCategory(id);
            fillDetails(jewel, brand, category);
        }
    }
}