using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DIP.DAL.DBTierTableAdapters;
namespace DIP.BLL
{
    public class BLL
    {
        LoginTableAdapter objLogin;
        SuiteTableAdapter objSuite;
        CustomerTableAdapter objCustomer;
        ItemsTableAdapter objItem;
        RoomsTableAdapter objRoom;

        public bool getLogin(string username, string password)
        {
            objLogin = new LoginTableAdapter();
            return Convert.ToBoolean(objLogin.GetLogin(username, password));
        }
        public DataTable getSuite()
        {
            objSuite = new SuiteTableAdapter();
            return objSuite.GetSuite();
        }
        public bool deleteSuite(int sid)
        {
            objSuite = new SuiteTableAdapter();
            return objSuite.DeleteSuite(sid) > 0;
        }
        public bool insertSuite(string a, decimal b)
        {
            objSuite = new SuiteTableAdapter();
            return objSuite.InsertSuite(a, b) > 0;
        }
        public bool updateSuite(string a, decimal b, int id)
        {
            objSuite = new SuiteTableAdapter();
            return objSuite.UpdateSuite(a, b, id) > 0;
        }
        public DataTable getCustomer()
        {
            objCustomer = new CustomerTableAdapter();
            return objCustomer.GetCustomer();
        }
        public bool insertCustomer(string name, string add, string ph, string aadhar)
        {
            objCustomer = new CustomerTableAdapter();
            return objCustomer.InsertCustomer(name, add, ph, aadhar) > 0;
        }
        public bool updateCustomer(string name, string add, string ph, string aadhar, int id)
        {
            objCustomer = new CustomerTableAdapter();
            return objCustomer.UpdateCustomer(name, add, ph, aadhar, id) > 0;
        }
        public DataTable getItem()
        {
            objItem = new ItemsTableAdapter();
            return objItem.GetItem();
        }
        public bool insertItem(int sid, string item_name, int count, decimal cost)
        {
            objItem = new ItemsTableAdapter();
            return objItem.InsertItem(sid, item_name, count, cost) > 0;
        }

        public bool updateItem(int sid, string item_name, int count, decimal cost, int Item_id)
        {
            objItem = new ItemsTableAdapter();
            return objItem.UpdateItem(sid, item_name, count, cost, Item_id) > 0;
        }
        public bool deleteItem(int Item_id)
        {
            objItem = new ItemsTableAdapter();
            return objItem.DeleteItem(Item_id) > 0;


        }
        public DataTable getSuite_ForDDL()
        {
            objSuite = new SuiteTableAdapter();
            return objSuite.GetSuite_ForDDL();
        }
        public DataTable getRoom_ForDDL(int sid)
        {
            objRoom = new RoomsTableAdapter();
            return objRoom.GetRoom_ForDDL(sid);
        }
        public DataTable getSID(string s)
        {
            objSuite = new SuiteTableAdapter();
            return objSuite.GetSID(s);
        }
        public bool insertRoom(int a,DateTime b,DateTime c,int d)
        {
            objRoom = new RoomsTableAdapter();
            return objRoom.InsertRoom(a,b,c,d)>0;
        }
        public DataTable getRoom()
        {
            objRoom = new RoomsTableAdapter();
            return objRoom.GetRoom();
        }
        public bool removeRoom(int id)
        {
            objRoom = new RoomsTableAdapter();
            return objRoom.RemoveRoom(id)>0;
        }
        public DataTable getBillByRoom(int room)
        {
            objRoom = new RoomsTableAdapter();
            return objRoom.GetBillByRoom(room);
        }
        public DataTable getCostBySID(int sid)
        {
            objSuite = new SuiteTableAdapter();
            return objSuite.GetCostBySID(sid);
        }
        public DataTable getItemBySID(int sid)
        {
            objItem = new ItemsTableAdapter();
            return objItem.GetItemBySID(sid);
        }
    }
}