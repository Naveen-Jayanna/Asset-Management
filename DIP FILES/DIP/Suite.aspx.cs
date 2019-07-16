using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DIP
{
    public partial class Suite : System.Web.UI.Page
    {
        static int id=0;
        BLL.BLL obj = new BLL.BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadSuite();

        }
        private void LoadSuite()
        {
            DataTable tab = obj.getSuite();
            if (tab.Rows.Count > 0)
            {
                gvSuite.DataSource = tab;
                gvSuite.DataBind();

            }
            else
            {
                gvSuite.Controls.Clear();
                lblMsg.Text = "Suites not yet added";
            }
        }

        protected void lbEdit_Click(object sender, EventArgs e)
        {
            GridViewRow gvr = (GridViewRow)((LinkButton)sender).Parent.Parent;
            id = int.Parse(((LinkButton)sender).CommandArgument);
            txtSuite.Text = gvr.Cells[0].Text;
            txtBase.Text = gvr.Cells[1].Text;
            btnSubmit.Text = "UPDATE";
        }
        protected void lbDelete_Click(object sender, EventArgs e)
        {
        
            GridViewRow gvr = (GridViewRow)((LinkButton)sender).Parent.Parent;
            id = int.Parse(((LinkButton)sender).CommandArgument);
            if(obj.deleteSuite(id))
            {
                
                LoadSuite();
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Sucessfully Deleted')", true);

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Deletion Failed!!')", true);
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {  
                if (btnSubmit.Text == "ADD")
                {

                    if (obj.insertSuite(txtSuite.Text,decimal.Parse(txtBase.Text)))
                    {
                        lblMsg.Text = "";
                        LoadSuite();
                        ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Suite Added Sucessfully')", true);
                        txtBase.Text="";
                        txtSuite.Text="";
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Operation Failed')", true);
                         txtBase.Text="";
                        txtSuite.Text="";
                    }
                }
                else
                {
                    if (obj.updateSuite(txtSuite.Text,decimal.Parse(txtBase.Text),id))
                    {
                        lblMsg.Text = "";
                        LoadSuite();
                        ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Suite Updated Sucessfully')", true);
                        btnSubmit.Text = "ADD";
                        txtSuite.Text="";
                        txtBase.Text="";

                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Updation Failed!!')", true);
                        btnSubmit.Text = "ADD";
                        txtSuite.Text="";
                        txtBase.Text="";
                    }
                }
            }
        }
    }
