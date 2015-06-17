using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using LibraryManagementApp.Model;

namespace LibraryManagementApp.DAL
{
    public class BookGateway
    {
        public string connectionString = WebConfigurationManager.ConnectionStrings["LibraryConString"].ConnectionString;
        public int Save(Book aBook)
        {
            SqlConnection connection = new SqlConnection(connectionString);


            connection.Open();
            string query = "INSERT INTO Table_Book VALUES('" + aBook.Title + "','" + aBook.Author + "','"+aBook.Publisher+"')";

            SqlCommand command = new SqlCommand(query, connection);

            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;
        }
        public List<Book> GetAllBooks()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Table_Book ";
            SqlCommand command = new SqlCommand(query, connection);
            List<Book> bookList = new List<Book>();
            
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Book aBook = new Book();

                aBook.Id = Convert.ToInt32(reader["Id"].ToString());
                aBook.Title = reader["Title"].ToString();
                aBook.Author = reader["Author"].ToString();
                aBook.Publisher = reader["Publisher"].ToString();
                bookList.Add(aBook);
            }
            reader.Close();
            connection.Close();

            return bookList;
        }
        public Book GetSingleBookInfo(string name)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Table_Book WHERE Title='" + name + "'";
            SqlCommand command = new SqlCommand(query, connection);

            Book aBook = new Book();
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                aBook.Id = Convert.ToInt32(reader["Id"].ToString());
                aBook.Title = reader["Title"].ToString();
                aBook.Author = reader["Author"].ToString();
                aBook.Publisher = reader["Publisher"].ToString();
           
            }
            reader.Close();
            connection.Close();

            return aBook;
        }

        public void SetBorrowedBook(Borrow borrowed)
        {
            SqlConnection connection = new SqlConnection(connectionString);


            connection.Open();
            string query = "INSERT INTO Table_Borrow VALUES('" + borrowed.MemberID + "','" + borrowed.BookID + "')";

            SqlCommand command = new SqlCommand(query, connection);

            command.ExecuteNonQuery();
            connection.Close();
           
        }
        public bool IsMemberExists(int memberId)
        {
            bool memberExists = false;

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT Id FROM Member WHERE Id='" + memberId + "'";

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                memberExists = true;
                break;
            }
            reader.Close();
            connection.Close();
            return memberExists;
        }
    }
}