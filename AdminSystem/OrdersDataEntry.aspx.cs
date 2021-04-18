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
        //create some test data to assign to the property
        AnOrder.ShippingInfo = txtShippingInfo.Text;
        //store the address in session
        Session["AnOrder"] = AnOrder;
        //navigate user to viewer page
        Response.Redirect("OrdersViewer.aspx");

        
        //create some test data to assign to the property
        AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
        //store the address in session
        Session["AnOrder"] = AnOrder;
        //navigate user to viewer page
        Response.Redirect("OrdersViewer.aspx");

       
        //create some test data to assign to the property
        AnOrder.Availability = Convert.ToBoolean(chkAvailability.Text);
        //store the address in session
        Session["AnOrder"] = AnOrder;
        //navigate user to viewer page
        Response.Redirect("OrdersViewer.aspx");

        
        //create some test data to assign to the property
        AnOrder.OrderId = Convert.ToInt32(txtOrderId.Text);
        //store the address in session
        Session["AnOrder"] = AnOrder;
        //navigate user to viewer page
        Response.Redirect("OrdersViewer.aspx");
























    }
}