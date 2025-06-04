using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDLabProject.Views.JewelPages.Admin
{
    public partial class HandleOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindOrders();
            }
        }

        private void BindOrders()
        {
            var orders = TransactionController.GetUnfinishedTransactions();
            gvOrders.DataSource = orders;
            gvOrders.DataBind();
        }
        protected void gvOrders_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "HandleOrder")
            {
                string[] args = e.CommandArgument.ToString().Split(';');
                int transactionId = int.Parse(args[0]);
                string status = args[1];
                TransactionController.HandleAction(transactionId, status);
                BindOrders();
            }
        }
    }
}