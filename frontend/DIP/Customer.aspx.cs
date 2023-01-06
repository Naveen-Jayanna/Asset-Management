using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DIP
{
    public partial class Customer : System.Web.UI.Page
    {
        static int id = 0;
        BLL.BLL obj = new BLL.BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }
        private void LoadCustomer()
        {
            DataTable tab = obj.getCustomer();
            if (tab.Rows.Count > 0)
            {
                gvCustomer.DataSource = tab;
                gvCustomer.DataBind();

            }
            else
            {
                gvCustomer.Controls.Clear();
                lblMsg.Text = "Customers not yet added";
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnSubmit.Text == "ADD")
            {

                if (obj.insertCustomer(txtName.Text,txtAdd.Text,txtPhone.Text,txtAadhar.Text))
                {
                    lblMsg.Text = "";
                    LoadCustomer();
                    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Customer Added Sucessfully')", true);
                    txtName.Text = "";
                    txtAdd.Text = "";
                    txtPhone.Text = "";
                    txtAadhar.Text = "";
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Operation Failed')", true);
                    txtName.Text = "";
                    txtAdd.Text = "";
                    txtPhone.Text = "";
                    txtAadhar.Text = "";
                }
            }
            else
            {
                if (obj.updateCustomer(txtName.Text, txtAdd.Text, txtPhone.Text, txtAadhar.Text, id))
                {
                    lblMsg.Text = "";
                    LoadCustomer();
                    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Customer Updated Sucessfully')", true);
                    btnSubmit.Text = "ADD";
                    txtName.Text = "";
                    txtAdd.Text = "";
                    txtPhone.Text = "";
                    txtAadhar.Text = "";

                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Updation Failed!!')", true);
                    btnSubmit.Text = "ADD";
                    txtName.Text = "";
                    txtAdd.Text = "";
                    txtPhone.Text = "";
                    txtAadhar.Text = "";
                }
            }
        }

        protected void lbEdit_Click(object sender, EventArgs e)
        {        
                GridViewRow gvr = (GridViewRow)((LinkButton)sender).Parent.Parent;
                id = int.Parse(((LinkButton)sender).CommandArgument);
                txtName.Text = gvr.Cells[0].Text;
                txtAdd.Text = gvr.Cells[1].Text;
                txtPhone.Text = gvr.Cells[2].Text;
                txtAadhar.Text = gvr.Cells[3].Text;
                btnSubmit.Text = "UPDATE";
        }

    }
}