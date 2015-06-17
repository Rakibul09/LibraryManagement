using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryManagementApp.DAL;
using LibraryManagementApp.Model;

namespace LibraryManagementApp.BLL
{
    public class BookManager
    {
        BookGateway gateway=new BookGateway();
      
        public string Save(Book aBook)
        {
            if (gateway.Save(aBook) > 0)
            {
                return "Saved succesfully.";
            }
            return "Save Failed";
        }

        public List<Book> GetAllBooks()
        {
            return gateway.GetAllBooks();
        }

        public Book getSingleBookInfo(string name)
        {
            return gateway.GetSingleBookInfo(name);
        }

        public string setBorrowedBook(Borrow borrowed)
        {
            
            if (gateway.IsMemberExists(borrowed.MemberID))
            {
                gateway.SetBorrowedBook(borrowed);
                return "Saved succesfully";
            }
            return "member already exists.";
        }
    }
}