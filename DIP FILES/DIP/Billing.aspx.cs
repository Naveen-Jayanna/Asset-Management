using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;

namespace DIP
{
    public partial class Billing : System.Web.UI.Page
    {
        int room = 0;
        int sid = 0;
        int cid = 0;
        DateTime cin;
        DateTime cout;
        BLL.BLL objbll = new BLL.BLL();
        MysqlConnector objsql = new MysqlConnector();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void LoadMissing()
        {
            DataTable tab = objsql.Print_Missing();
            if (tab.Rows.Count > 0)
            {
                gvMissing.DataSource = tab;
                gvMissing.DataBind();

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
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

            int RoomCost = System.Convert.ToInt32(double.Parse( row["Base_Price"].ToString()));
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

            foreach (DictionaryEntry entry in ActualItem)
            {
                if (MissingItem.ContainsKey(entry.Key))
                {
                    //bill += int.Parse(entry.Value.ToString()) - Convert.ToInt32(MissingItem[entry.Key]);
                    bill += Convert.ToInt32(ActualItem[entry.Key]) * Convert.ToInt32(MissingItem[entry.Key]);
                }
            }
            bill += totalRoomCost;
           txtRoom.Text = bill.ToString();
            LoadMissing();
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