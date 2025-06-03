using System;
using System.Web.UI.WebControls;
using PSDLabProject.Handlers;  
using PSDLabProject.Models;    
using System.Collections.Generic;

namespace JAwelsAndDiamonds
{
    public partial class Cart : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCart();
            }
        }

        private void BindCart()
        {
            int userId = Convert.ToInt32(Session["UserID"]);
            if (userId == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }

            List<PSDLabProject.Models.Cart> items = Handler.GetCartItems(userId);
            CartGrid.DataSource = items;
            CartGrid.DataBind();

            decimal total = Handler.CalculateTotal(items);
            lblTotal.Text = "Total: " + total.ToString("C");
        }
        protected void btnClearCart_Click1(object sender, EventArgs e)
        {
            Handler.ClearCart(Convert.ToInt32(Session["UserID"]));
            BindCart();
        }

        protected void btnCheckout_Click1(object sender, EventArgs e)
        {
            string payment = ddlPayment.SelectedValue;
            if (string.IsNullOrEmpty(payment))
            {
                return;
            }

            Handler.CheckoutCart(Convert.ToInt32(Session["UserID"]), payment);
            BindCart();
        }

        protected void CartGrid_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = CartGrid.Rows[index];

            int userId = Convert.ToInt32(Session["UserID"]);
            int jewelId = Convert.ToInt32(row.Cells[0].Text);
            string qtyText = ((TextBox)row.FindControl("txtQuantity")).Text;

            if (int.TryParse(qtyText, out int quantity) && quantity > 0)
            {
                if (e.CommandName == "UpdateItem")
                {
                    Handler.UpdateCartItem(userId, jewelId, quantity);
                }
            }

            if (e.CommandName == "RemoveItem")
            {
                Handler.RemoveCartItem(userId, jewelId);
            }

            BindCart();
        }
    }
}
