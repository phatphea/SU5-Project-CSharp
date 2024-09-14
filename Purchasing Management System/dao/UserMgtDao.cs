using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchasing_Management_System.dao
{
    internal class UserMgtDao
    {
        public List<Dictionary<string, object>> LoadAllUsers()
        {
            List<Dictionary<string, object>> resp = new List<Dictionary<string, object>>();
            //logic get data from database tblUser
            OleDbCommand cmd = new OleDbCommand(" select UserID, UserName, UserPassword, UserPosition, UserRole, Is_Deactivated from [USER] order by UserID asc ", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string uid = dr["userID"].ToString();
                string uname = dr["UserName"].ToString();
                string upass = dr["UserPassword"].ToString();
                string UserPosition = dr["UserPosition"].ToString();
                string UserRole = dr["UserRole"].ToString();
                string Is_Deactivated = dr["Is_Deactivated"].ToString();
                Dictionary<string, object> usr = new Dictionary<string, object>();
                usr.Add("uid", uid);
                usr.Add("uname", uname);
                usr.Add("upass", upass);
                usr.Add("UserPosition", UserPosition);
                usr.Add("UserRole", UserRole);
                usr.Add("Is_Deactivated", Is_Deactivated);
                resp.Add(usr);
            }
            dr.Close();
            return resp;

        }
        public Boolean isDuplicate(String usr)
        {

            OleDbCommand cmd = new OleDbCommand(" select UserID, UserName, UserPassword from [USER] where UserName='" + usr + "' ", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            Boolean test = dr.Read();
            dr.Close();
            if (test == true)
            {
                return true;
            }
            return false;
        }

        public long addUser(String usrName, String passWord, String usrPosition, String usrRole)
        {

            OleDbCommand cmd = new OleDbCommand(" INSERT INTO [USER] ( UserName, UserPassword, UserPosition, UserRole) VALUES('" + usrName + "','" + passWord + "','"+usrPosition+"','"+usrRole+"') ", Program.con);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                //after insert success then get userId by username
                cmd.CommandText = " select UserID from [USER] where UserName='" + usrName + "'";
                int userId = Convert.ToInt32(cmd.ExecuteScalar());
                return userId;
            }
            return 0;
        }
        public Boolean deleteUser(String userId)
        {
            OleDbCommand cmd = new OleDbCommand(" delete from [USER] where UserID = " + userId + " ", Program.con);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                return true;
            }
            return false;
        }
        public Boolean updateUser(String userId, String usrName, String usrpassWord, String usrPosition, String usrRole)
        {
            OleDbCommand cmd = new OleDbCommand(" update [USER] set UserName='" + usrName + "', UserPassword='" + usrpassWord + "', UserPosition='"+usrPosition+ "', UserRole='" + usrRole+"' where UserID = " + userId + " ", Program.con);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                return true;
            }
            return false;
        }
        public List<Dictionary<string, object>> searchUserByID(String id)
        {
            List<Dictionary<string, object>> resp = new List<Dictionary<string, object>>();
            //logic get data from database tblUser
            OleDbCommand cmd = new OleDbCommand("select UserID, UserName, UserPassword, UserPosition, UserRole, Is_Deactivated from [USER] where UserID=" + id + " ", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string uid = dr["userID"].ToString();
                string uname = dr["UserName"].ToString();
                string upass = dr["UserPassword"].ToString();
                string UserPosition = dr["UserPosition"].ToString();
                string UserRole = dr["UserRole"].ToString();
                string Is_Deactivated = dr["Is_Deactivated"].ToString();
                Dictionary<string, object> usr = new Dictionary<string, object>();
                usr.Add("uid", uid);
                usr.Add("uname", uname);
                usr.Add("upass", upass);
                usr.Add("UserPosition", UserPosition);
                usr.Add("UserRole", UserRole);
                usr.Add("Is_Deactivated", Is_Deactivated);
                resp.Add(usr);
            }
            dr.Close();
            return resp;

        }
        public List<Dictionary<string, object>> searchUsersByusrName(String usrName)
        {
            List<Dictionary<string, object>> resp = new List<Dictionary<string, object>>();
            //logic get data from database tblUser
            OleDbCommand cmd = new OleDbCommand("select UserID, UserName, UserPassword, UserPosition, UserRole, Is_Deactivated from [USER] where UserName Like '%" + usrName + "%' ", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string uid = dr["userID"].ToString();
                string uname = dr["UserName"].ToString();
                string upass = dr["UserPassword"].ToString();
                string UserPosition = dr["UserPosition"].ToString();
                string UserRole = dr["UserRole"].ToString();
                string Is_Deactivated = dr["Is_Deactivated"].ToString();
                Dictionary<string, object> usr = new Dictionary<string, object>();
                usr.Add("uid", uid);
                usr.Add("uname", uname);
                usr.Add("upass", upass);
                usr.Add("UserPosition", UserPosition);
                usr.Add("UserRole", UserRole);
                usr.Add("Is_Deactivated", Is_Deactivated);
                resp.Add(usr);
            }
            dr.Close();
            return resp;

        }
        public Boolean deactivateUser(String userId, String deactivate)
        {
            OleDbCommand cmd = new OleDbCommand(" update [USER] set Is_Deactivated='" + deactivate + "' where UserID = " + userId + " ", Program.con);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
