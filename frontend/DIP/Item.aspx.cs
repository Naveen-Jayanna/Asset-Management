using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DIP
{
    public partial class Item : System.Web.UI.Page
    {
        static int id = 0;
        BLL.BLL obj = new BLL.BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadItem();
        }
        
        private void LoadItem()
        {
            DataTable tab = obj.getItem();
            if(tab.Rows.Count > 0)
            {
                 gvItem.DataSource = tab;
                gvItem.DataBind();
            }
            else
            {
                gvItem.Controls.Clear();
                lblMsg.Text = "Items not yet added";
            }

    }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnSubmit.Text == "ADD")
            {

                if (obj.insertItem(int.Parse(txtSuite.Text), txtAddItem.Text, int.Parse(txtCount.Text), decimal.Parse(txtCost.Text)))
                {
                    lblMsg.Text = "";
                    LoadItem();
                    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Items Added Sucessfully')", true);
                    txtSuite.Text = "";
                    txtAddItem.Text = "";
                    txtCount.Text = "";
                    txtCost.Text = "";
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Operation Failed')", true);
                    txtSuite.Text = "";
                    txtAddItem.Text = "";
                    txtCount.Text = "";
                    txtCost.Text = "";
                }
            }
            else
            {
                if (obj.updateItem(int.Parse(txtSuite.Text), txtAddItem.Text,int.Parse(txtCount.Text), decimal.Parse(txtCost.Text), id))
                {
                    lblMsg.Text = "";
                    LoadItem();
                    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Items Updated Sucessfully')", true);
                    btnSubmit.Text = "ADD";
                    txtSuite.Text = "";
                    txtAddItem.Text = "";
                    txtCount.Text = "";
                    txtCost.Text = "";

                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Updation Failed!!')", true);
                    btnSubmit.Text = "ADD";
                    txtSuite.Text = "";
                    txtAddItem.Text = "";
                    txtCount.Text = "";
                    txtCost.Text = "";
                }
            }
        }
        protected void lnEdit_Click(object sender, EventArgs e)
        {
            GridViewRow gvr = (GridViewRow)((LinkButton)sender).Parent.Parent;
            id = int.Parse(((LinkButton)sender).CommandArgument);
            txtSuite.Text = gvr.Cells[0].Text;
            txtAddItem.Text = gvr.Cells[1].Text;
            txtCount.Text = gvr.Cells[2].Text;
            txtCost.Text = gvr.Cells[3].Text;
            btnSubmit.Text = "UPDATE";
        }

        protected void lnDelete_Click(object sender,EventArgs e)
        {
            GridViewRow gvr = (GridViewRow)((LinkButton)sender).Parent.Parent;
            id = int.Parse(((LinkButton)sender).CommandArgument);
            if (obj.deleteItem(id))
            {
                LoadItem();
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Sucessfully Deleted')", true);
                txtSuite.Text = "";
                txtAddItem.Text = "";
                txtCount.Text = "";
                txtCost.Text = "";

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Deletion Failed!!')", true);
            }
        }
        }
}