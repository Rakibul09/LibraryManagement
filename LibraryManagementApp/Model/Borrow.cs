using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementApp.Model
{
    public class Borrow
    {
        public int BookID { set; get; }
        public int MemberID { set; get; }
    }
}