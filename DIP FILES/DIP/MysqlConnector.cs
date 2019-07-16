using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections;

namespace DIP
{
    public class MysqlConnector
    {
        string cs = "server=18.225.27.58;database=digitalimage;user id=user;password=digitalimage";
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        MySqlDataAdapter adp = null;

        public MysqlConnector()
        {
            con = new MySqlConnection(cs);
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
        }

        public void Process(Hashtable items)
        {
            int missing = 0;
            DataTable tab = getAllCapturedAssets();
            Hashtable Assets = new Hashtable();
            foreach (DataRow dr in tab.Rows)
            {
                Assets.Add(dr["Item_Name"], dr["ItemCount"]);
            }
            //foreach (string el in items.Keys)
            //{

            //}
            foreach (DictionaryEntry entry in items)
            {
                if (Assets.ContainsKey(entry.Key))
                {

                    if (!Assets.ContainsValue(entry.Value))
                    {
                        missing = int.Parse(entry.Value.ToString()) - Convert.ToInt32(Assets[entry.Key]);
                        if (missing > 0)
                            Missing_Item(entry.Key.ToString(),missing);
                        
                    }
                }
                else
                {
                    Missing_Item(entry.Key.ToString(), int.Parse(entry.Value.ToString()));
                }
            }
        }

        public bool Flush()
        {
            bool res = false;
            bool res1 = false;
            try
            {
                cmd.CommandText = "Delete from Asset";
                res=cmd.ExecuteNonQuery()>0;
                cmd.CommandText = "Delete from Missing_Item";
                res1=cmd.ExecuteNonQuery()>0;
            }
            catch
            {
                res = false;
                res1 = false;
            }
            return res && res1;
        }

        public DataTable getAllCapturedAssets()
        {
            cmd.CommandText = "select count(*) as ItemCount,Item_Name from Asset group by Item_Name";
            adp = new MySqlDataAdapter(cmd);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }
        public void Missing_Item(string key,int value)
        {
            cmd.CommandText=string.Format("insert into Missing_Item (Item,Count) values ('{0}',{1})",key,value);
            cmd.ExecuteNonQuery();
        }

        public DataTable Print_Missing()  //for grid view to print missing items
        {
            cmd.CommandText = "select * from Missing_Item";
            adp = new MySqlDataAdapter(cmd);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

    }
}