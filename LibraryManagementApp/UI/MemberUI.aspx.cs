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
    public partial class MemberUI : System.Web.UI.Page
    {
        MemberManager manager = new MemberManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveMemberButton_Click(object sender, EventArgs e)
        {
            Member aMember=new Member();
            aMember.Name = nameTextBox.Text;
            aMember.Number = Convert.ToInt32(numberTextBox.Text);
            testLabel2.Text=manager.Save(aMember);

        }
    }
}