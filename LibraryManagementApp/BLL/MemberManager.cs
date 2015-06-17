using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryManagementApp.DAL;
using LibraryManagementApp.Model;

namespace LibraryManagementApp.BLL
{
    public class MemberManager
    {
        MemberGateway gateway=new MemberGateway();

        public string Save(Member aMember)
        {
            if (gateway.Save(aMember) > 0)
            {
                return "Saved succesfully";
            }
            return "save failed";
        }
    }
}