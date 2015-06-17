using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementApp.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
    }
}