using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {

        //create a new instance of clsOrders
        clsOrders AnOrder = new clsOrders();
        //capture OrderDate
        string OrderDate = txtOrderDate.Text;
        //capture Shippinginfo
        string ShippingInfo = txtShippingInfo.Text;
        //variable to store error messages
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(OrderDate, ShippingInfo);
        if (Error == "")
        {
            //capture the Orderdate
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            //capture the shipping info
            AnOrder.ShippingInfo = ShippingInfo;
            //store the orderid in the Orders in the session object
            Session["AnOrder"] = AnOrder;
            //redirect to the viewer page
            Response.Write("Ordersviewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
        
        
    }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            //create an instance of the order class
            clsOrders AnOrder = new clsOrders();
            //variable to store the primary key
            Int32 OrderId;
            // variable to store the result of the find operation
            Boolean Found = false;
            //get the primary key entered by the user
            OrderId = Convert.ToInt32(txtOrderId.Text);
            //find the record
            Found = AnOrder.Find(OrderId);
            //if found
            if (Found == true)
            {
                //display the values of the properties in the form

                txtOrderDate.Text = AnOrder.OrderDate.ToString();
                txtShippingInfo.Text = AnOrder.ShippingInfo;
             }





        } } 





     