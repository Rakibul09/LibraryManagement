<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BorrowUI.aspx.cs" Inherits="LibraryManagementApp.BorrowUI" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Title of the document</title>
    <link href="../Style.css" rel="stylesheet" />
    <link href="../reset.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="wrapper">
    
        <header>
            <div class="banner">
                
            </div>
              <div class="logo">
                  
              </div>

        </header>
        <nav>
            <ul>
                <li> <a href="BookUI.aspx">Add Book</a> </li>
            
                <li> <a href="MemberUI.aspx">Add Member</a> </li> 
                
                <li> <a href="BorrowUI.aspx">Borrow Book</a> </li>
                
                <li><a href="ReturnUI.aspx">Return Book</a> </li>
                
                <li><a href="DefaultUI.aspx">About</a></li>
           
                 </ul>
        </nav>
    <div class="container">
        <table>
            <tr>
                <td><asp:Label ID="Label1" runat="server" Text="Enter member no."></asp:Label></td>
                <td>
                    <asp:TextBox ID="memberBorrowTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Select a book"></asp:Label></td>
                <td>
                    <asp:DropDownList ID="bookSelectionDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="bookSelectionDropDownList_SelectedIndexChanged"></asp:DropDownList></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Author"></asp:Label></td>
                <td>
                    <asp:TextBox ID="authorBorrowTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Publisher"></asp:Label></td>
                <td>
                    <asp:TextBox ID="publisherBorrowTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="borrowButton" runat="server" Text="Borrow" OnClick="borrowButton_Click" style="height: 26px" /></td>
            </tr>
        </table>
        <br/>
        <asp:Label ID="testLabel3" runat="server" Text="Label"></asp:Label>
    </div>
    </div>
        
    </form>
</body>
</html>
