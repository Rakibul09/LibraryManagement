using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryManagementApp.BLL;
using LibraryManagementApp.Model;

namespace LibraryManagementApp
{
    public partial class BorrowUI : System.Web.UI.Page
    {
        BookManager manager = new BookManager();
        Book aBook = new Book(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadBorrowDropDownList();
                aBook = manager.getSingleBookInfo(bookSelectionDropDownList.SelectedItem.Text);
                authorBorrowTextBox.Text = aBook.Author;
                publisherBorrowTextBox.Text = aBook.Publisher;

            }
        }

        protected void borrowButton_Click(object sender, EventArgs e)
        {
            Borrow borrowed = new Borrow();
            borrowed.BookID = Convert.ToInt32(bookSelectionDropDownList.SelectedValue);
            borrowed.MemberID = Convert.ToInt32(memberBorrowTextBox.Text);
            testLabel3.Text=manager.setBorrowedBook(borrowed);
        }

        protected void bookSelectionDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            aBook = manager.getSingleBookInfo(bookSelectionDropDownList.SelectedItem.Text);
            
            authorBorrowTextBox.Text=aBook.Author;
            publisherBorrowTextBox.Text = aBook.Publisher;

        }
        public void LoadBorrowDropDownList()
        {
            bookSelectionDropDownList.DataSource = manager.GetAllBooks();
            bookSelectionDropDownList.DataTextField = "Title";
            bookSelectionDropDownList.DataValueField = "Id";
            bookSelectionDropDownList.DataBind();
        }
    }
}