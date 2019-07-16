using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;
using System.Threading;

namespace DIP
{
    public partial class Billing : System.Web.UI.Page
    {
        int test=1;
        int x = 0;
        int room = 0;
        int sid = 0;
        int cid = 0;
        DateTime cin;
        DateTime cout;
        BLL.BLL objbll = new BLL.BLL();
        MysqlConnector objsql = new MysqlConnector();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMissing.Text = "";
        }

        private void LoadMissing()
        {
            DataTable tab = objsql.Print_Missing();
            if (tab.Rows.Count > 0)
            {
                gvMissing.DataSource = tab;
                gvMissing.DataBind();
                lblMissing.Text = "Missing Items";
            }
        }

        private void process()
        {
            while (test == 1)
            {
                DataTable t = objsql.Testing();
                DataRow row = t.Rows[0];
                test = int.Parse(row["test"].ToString());
                test += 1;
                Thread.Sleep(10000);
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnSubmit.Text == "Submit")
            {

            objsql.Testing_Insert(1);
            Thread.Sleep(10000);
            System.Threading.Thread th = new Thread(new ThreadStart(process));
            th.Start();
            while (test != 2) ;
            

                getData();
                TimeSpan interval = cout - cin;
                double days = interval.TotalDays;
                int bill = 0;
                int totalDays = System.Convert.ToInt32(System.Math.Ceiling(days));
                //if (days - int.Parse(days.ToString()) > 0)
                //{
                //    totalDays += 1;
                //}

                DataTable t = objbll.getCostBySID(sid);
                DataRow row = t.Rows[0];

                int RoomCost = System.Convert.ToInt32(double.Parse(row["Base_Price"].ToString()));
                int totalRoomCost = totalDays * RoomCost;


                //txtRoom.Text = totalRoomCost.ToString();

                DataTable tab = objbll.getItemBySID(sid);
                Hashtable items = new Hashtable();
                Hashtable ActualItem = new Hashtable();
                Hashtable MissingItem = new Hashtable();

                foreach (DataRow dr in tab.Rows)
                {
                    items.Add(dr["Item_Name"], dr["Count"]);
                    ActualItem.Add(dr["Item_Name"], dr["Cost"]);
                }

                objsql.Process(items);
                DataTable miss = new DataTable();
                miss = objsql.Print_Missing();
                foreach (DataRow dr in miss.Rows)
                {
                    MissingItem.Add(dr["Item"], dr["Count"]);
                }
                int missingtotal=0;
                foreach (DictionaryEntry entry in ActualItem)
                {
                    if (MissingItem.ContainsKey(entry.Key))
                    {
                        //bill += int.Parse(entry.Value.ToString()) - Convert.ToInt32(MissingItem[entry.Key]);
                        missingtotal += Convert.ToInt32(ActualItem[entry.Key]) * Convert.ToInt32(MissingItem[entry.Key]);
                        
                    }
                }
                bill += missingtotal;
                bill += totalRoomCost;
                //txtRoom.Text = bill.ToString();
                LoadMissing();
                btnSubmit.Text = "Bill";

                lblMissingMsg.Text = "----------------------------Total Bill Structure----------------------------";
                lblBasePrice.Text = "Room Cost: " + totalRoomCost.ToString();
                lblItems.Text = "Missing Item Cost: "+missingtotal.ToString();
                lblTotal.Text = "Total Bill: "+bill.ToString();

            }
            else {

                if (objsql.Flush())
                {
                   

                    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Payment Successful')", true);
                    btnSubmit.Text = "Submit";
                    txtRoom.Text = "";
                    lblMissing.Text = "";
                    gvMissing.Controls.Clear();
                    lblMissingMsg.Text = "";
                    lblBasePrice.Text = "";
                    lblItems.Text = "";
                    lblTotal.Text = "";
                    txtRoom.Text = "";
                }

                else
                {
                    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Network Error')", true);
                }
            }
        }

        private void getData()
        {
            room = int.Parse(txtRoom.Text);
            DataTable tab = objbll.getBillByRoom(room);
            DataRow row = tab.Rows[0];
            cid = int.Parse(row["CID"].ToString());
            sid = int.Parse(row["SID"].ToString());
            String z = row["Check_In"].ToString();
            String x = z.Split(' ')[0];
            String y = z.Split(' ')[1];
            cin = new System.DateTime(int.Parse(x.Split('-')[2]), int.Parse(x.Split('-')[1]), int.Parse(x.Split('-')[0]), int.Parse(y.Split(':')[0]), int.Parse(y.Split(':')[1]), int.Parse(y.Split(':')[2]));
            z = row["Check_Out"].ToString();
            x = z.Split(' ')[0];
            y = z.Split(' ')[1];
            cout = new System.DateTime(int.Parse(x.Split('-')[2]), int.Parse(x.Split('-')[1]), int.Parse(x.Split('-')[0]), int.Parse(y.Split(':')[0]), int.Parse(y.Split(':')[1]), int.Parse(y.Split(':')[2]));
        }


    }
}