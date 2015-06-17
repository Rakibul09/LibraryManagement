<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookUI.aspx.cs" Inherits="LibraryManagementApp.BookUI" %>

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
                    <td><asp:Label ID="Label1" runat="server" Text="Title"></asp:Label></td>
                    <td><asp:TextBox ID="titleTextBox" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label2" runat="server" Text="Author"></asp:Label></td>
                    <td><asp:TextBox ID="authorTextBox" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label3" runat="server" Text="Publisher"></asp:Label></td>
                    <td><asp:TextBox ID="publisherTextBox" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="saveBookButton" runat="server" Text="Save" OnClick="saveBookButton_Click" /></td>
                </tr>
            </table>
            <br/>
            <asp:Label ID="testLabel" runat="server" Text="Label"></asp:Label>
        </div>
    </div>
        
    </form>
</body>
</html>

