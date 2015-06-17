<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberUI.aspx.cs" Inherits="LibraryManagementApp.MemberUI" %>

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
                <td><asp:Label ID="Label1" runat="server" Text="Number"></asp:Label></td>
                <td>
                    <asp:TextBox ID="numberTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label></td>
                <td>
                    <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="saveMemberButton" runat="server" Text="Save" OnClick="saveMemberButton_Click" /></td>
            </tr>
        </table>
        <br/>
        <asp:Label ID="testLabel2" runat="server" Text="Label"></asp:Label>
    </div>
    </div>
        
    </form>
</body>
</html>

