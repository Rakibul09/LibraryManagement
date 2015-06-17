using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using LibraryManagementApp.Model;

namespace LibraryManagementApp.DAL
{
    public class MemberGateway
    {
        public string connectionString = WebConfigurationManager.ConnectionStrings["LibraryConString"].ConnectionString;
        public int Save(Member aMember)
        {
            SqlConnection connection = new SqlConnection(connectionString);


            connection.Open();
            string query = "INSERT INTO Table_Member VALUES('" + aMember.Number + "','" + aMember.Name + "')";

            SqlCommand command = new SqlCommand(query, connection);

            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;
        }
    }
}