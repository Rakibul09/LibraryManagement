<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefaultUI.aspx.cs" Inherits="LibraryManagementApp.DefaultUI" %>

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
    
    </div>
        
    </form>
</body>
</html>
