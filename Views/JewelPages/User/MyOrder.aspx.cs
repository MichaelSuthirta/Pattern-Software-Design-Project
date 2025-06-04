using PSDLabProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDLabProject.Views.JewelPages.User
{
    public partial class MyOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null || Session["Role"]?.ToString() != "Customer")
            {
                Response.Redirect("~/Login.aspx");
            }

            if (!IsPostBack)
            {
                LoadOrders();
            }
        }

        private void LoadOrders()
        {
            int userId = int.Parse(Session["UserID"].ToString());

            using (DatabaseProjectEntities db = new DatabaseProjectEntities())
            {
                var orders = db.TransactionHeaders
                    .Where(t => t.UserID == userId)
                    .Select(t => new
                    {
                        t.TransactionID,
                        t.TransactionDate,
                        t.PaymentMethod,
                        t.TransactionStatus
                    }).ToList();

                gvOrders.DataSource = orders;
                gvOrders.DataBind();
            }
        }

        protected void gvOrders_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            int transactionId = Convert.ToInt32(e.CommandArgument);

            using (DatabaseProjectEntities db = new DatabaseProjectEntities())
            {
                var order = db.TransactionHeaders.FirstOrDefault(t => t.TransactionID == transactionId);

                if (order == null) return;

                if (e.CommandName == "ViewDetails")
                {
                    Response.Redirect($"TransactionDetail.aspx?TransactionID={transactionId}");
                }
                else if (e.CommandName == "Confirm" && order.TransactionStatus == "Arrived")
                {
                    order.TransactionStatus = "Done";
                    db.SaveChanges();
                    LoadOrders();
                }
                else if (e.CommandName == "Reject" && order.TransactionStatus == "Arrived")
                {
                    order.TransactionStatus = "Rejected";
                    db.SaveChanges();
                    LoadOrders();
                }
            }
        }
    }
}