using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DIP
{
    public partial class Login : System.Web.UI.Page
    {
        BLL.BLL objbll = new BLL.BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (objbll.getLogin(tbemail.Text, tbpassword.Text))
                Response.Redirect("Suite.aspx");
        }
    }
}