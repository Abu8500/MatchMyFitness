<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="OrderId" runat="server" Text="OrderId"></asp:Label>
        <asp:TextBox ID="txtOrderId" runat="server" Width="209px"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkAvailability" runat="server" Text="Availability" />
        </p>
        <asp:Label ID="lblOrderDate" runat="server" Text="OrderDate"></asp:Label>
        <asp:TextBox ID="txtOrderDate" runat="server" width="217px"></asp:TextBox>
        <p>
            <asp:Label ID="lblShippingInfo" runat="server" Text="ShippingInfo"></asp:Label>
            <asp:TextBox ID="txtShippingInfo" runat="server" width="217px"></asp:TextBox>
        </p>
        <asp:Label ID="Label1" runat="server" Text="[lblError]"></asp:Label>
        <p>
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="Ok" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
