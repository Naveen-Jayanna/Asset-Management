using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace DIP
{
    public partial class Room : System.Web.UI.Page
    {
        BLL.BLL obj = new BLL.BLL();
        static int id = 0;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadRoom();
            if (!IsPostBack)
            {
                ddlSuite.DataSource = obj.getSuite();
                ddlSuite.DataTextField ="Suite_Type";
                ddlSuite.DataValueField ="SID";
                ddlSuite.DataBind();
                ddlSuite.Items.Insert(0, "SELECT");
                //String a = "SELECT";
                //String b=ddlSuite.SelectedItem.Text;
            }        
        }
        private void LoadRoom()
        {
            DataTable tab = obj.getRoom();
            if (tab.Rows.Count > 0)
            {
                gvRoom.DataSource = tab;
                gvRoom.DataBind();

            }
            else
            {
                gvRoom.Controls.Clear();
                lblMsg.Text = "Rooms not yet added";
            }
        }
        protected void ddlSuite_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlRoom.DataSource = obj.getRoom_ForDDL(int.Parse(ddlSuite.SelectedValue));
            ddlRoom.DataTextField = "Room_No";
            ddlRoom.DataValueField = "Room_No";
            ddlRoom.DataBind();
            ddlRoom.Items.Insert(0, "SELECT");
        }
        
         protected void ddlRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = int.Parse(ddlRoom.SelectedValue);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            
            
                String c = txtCheckIn.Text;
                String a = c.Split(' ')[0];
                String b = c.Split(' ')[1];
                System.DateTime date1 = new System.DateTime(int.Parse(a.Split('-')[2]), int.Parse(a.Split('-')[1]),int.Parse(a.Split('-')[0]), int.Parse(b.Split(':')[0]), int.Parse(b.Split(':')[1]), int.Parse(b.Split(':')[2]));
                String z = txtCheckOut.Text;
                String  x= z.Split(' ')[0];
                String y = z.Split(' ')[1];
                System.DateTime date2 = new System.DateTime(int.Parse(x.Split('-')[2]), int.Parse(x.Split('-')[1]), int.Parse(x.Split('-')[0]), int.Parse(y.Split(':')[0]), int.Parse(y.Split(':')[1]), int.Parse(y.Split(':')[2]));
                //System.DateTime date1 = new System.DateTime(2015, 3, 10, 2, 15, 10);
                if (obj.insertRoom(int.Parse(txtCID.Text), date1, date2,id))
                {
                    lblMsg.Text = "";
                    LoadRoom();
                    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Room Sucessfully Booked')", true);
                    txtCID.Text = "";
                    txtCheckIn.Text = "";
                    txtCheckOut.Text = "";
                    Response.Redirect("Room.aspx");
                    
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Operation Failed')", true);
                    txtCID.Text = "";
                    txtCheckIn.Text = "";
                    txtCheckOut.Text = "";
                    Response.Redirect("Room.aspx");
                }          
            
        }        
    }
}