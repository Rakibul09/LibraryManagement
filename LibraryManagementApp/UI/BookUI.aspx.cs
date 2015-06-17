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
    public partial class BookUI : System.Web.UI.Page
    {
        BookManager manager = new BookManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveBookButton_Click(object sender, EventArgs e)
        {
            Book aBook=new Book();
            
            aBook.Title = titleTextBox.Text;
            aBook.Author = authorTextBox.Text;
            aBook.Publisher = publisherTextBox.Text;
            testLabel.Text=manager.Save(aBook);
            
        }
    }
}