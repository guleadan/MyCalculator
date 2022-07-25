<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MyCalculator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Calculator</title>
    <script>
        var x = document.getElementById("firstNumber").value();
        var y = document.getElementById("secondNumber").value();
        


    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server">X=</asp:Label>
            <input type="text" runat="server" id="firstNumber" /><br />
            <asp:Label runat="server">Y=</asp:Label>
            <input type="text" runat="server" id="secondNumber" /><br />
            <asp:DropDownList ID="ddl" runat="server">
                <asp:ListItem Value="Addition">Addition</asp:ListItem>
                <asp:ListItem Value="Subtraction">Subtraction</asp:ListItem> 
                <asp:ListItem Value="Multiplication">Multiplication</asp:ListItem>
                <asp:ListItem Value="Division">Division</asp:ListItem>
            </asp:DropDownList> <br />
            <asp:Button runat="server" ID="btn" text="Calculate" OnCLick="btn_Click" /><br />
           
            

            


        </div>
    </form>
</body>
</html>
