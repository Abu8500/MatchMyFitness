using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;



public partial class _1_List : System.Web.UI.Page
{


    //This function is for the load event of the page
    protected void Page_Load(object sender, EventArgs e)
    {

        //if first time page is being displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrders();
        }


    }


    protected void DisplayOrders()
    {


        //create instance of class
        clsOrdersCollection Orders = new clsOrdersCollection();
        //set the data source to list of orders in collection
        lstOrders.DataSource = Orders.OrderList;
        //set the name of primary key
        lstOrders.DataValueField = "OrderId";
        //set the data field to display
        lstOrders.DataTextField = "ShippingInfo";
        //bind data
        lstOrders.DataBind();

    

    }


   
}
    