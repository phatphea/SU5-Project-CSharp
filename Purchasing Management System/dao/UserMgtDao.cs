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
        /*public List<Dictionary<string, object>> LoadAllUsers()
        {
            List<Dictionary<string, object>> resp = new List<Dictionary<string, object>>();
            //logic get data from database tblUser
            OleDbCommand cmd = new OleDbCommand(" select UserID, UserName, UserPassword, Position, UserRole from [USER] ", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string uid = dr["userID"].ToString();
                string uname = dr["UserName"].ToString();
                string upass = dr["UserPassword"].ToString();
                string Position = dr["Position"].ToString();
                string UserRole = dr["UserRole"].ToString();
                Dictionary<string, object> usr = new Dictionary<string, object>();
                usr.Add("uid", uid);
                usr.Add("uname", uname);
                usr.Add("upass", upass);
                usr.Add("Position", Position);
                usr.Add("UserRole", UserRole);
                resp.Add(usr);
            }
            dr.Close();
            return resp;

        }*/
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

        public long addUser(String usrName, String passWord, String position, String role)
        {

            OleDbCommand cmd = new OleDbCommand(" INSERT INTO [USER] ( UserName, UserPassword, Position, UserRole) VALUES('" + usrName + "','" + passWord + "', '" + position + "','" + role + "') ", Program.con);
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
        public Boolean updateUser(String userId, String usrName, String usrpassWord, String position, String role)
        {
            OleDbCommand cmd = new OleDbCommand(" update [USER] set UserName='" + usrName + "', UserPassword='" + usrpassWord + "', Position='"+position+"', Role='"+role+"' where UserID = " + userId + " ", Program.con);
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
            OleDbCommand cmd = new OleDbCommand("select UserID, UserName, UserPassword, Position, Role from [USER] where UserID=" + id + " ", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string uid = dr["userID"].ToString();
                string uname = dr["UserName"].ToString();
                string upass = dr["UserPassword"].ToString();
                string Position = dr["Position"].ToString();
                string Role = dr["Role"].ToString();
                Dictionary<string, object> usr = new Dictionary<string, object>();
                usr.Add("uid", uid);
                usr.Add("uname", uname);
                usr.Add("upass", upass);
                usr.Add("Position", Position);
                usr.Add("Role", Role);
                resp.Add(usr);
            }
            dr.Close();
            return resp;

        }
        public List<Dictionary<string, object>> searchUsersByusrName(String usrName)
        {
            List<Dictionary<string, object>> resp = new List<Dictionary<string, object>>();
            //logic get data from database tblUser
            OleDbCommand cmd = new OleDbCommand("select UserID, UserName, UserPassword, Role from [USER] where UserName Like '%" + usrName + "%' ", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string uid = dr["userID"].ToString();
                string uname = dr["UserName"].ToString();
                string upass = dr["UserPassword"].ToString();
                string Position = dr["Position"].ToString();
                string Role = dr["Role"].ToString();
                Dictionary<string, object> usr = new Dictionary<string, object>();
                usr.Add("uid", uid);
                usr.Add("uname", uname);
                usr.Add("upass", upass);
                usr.Add("Position", Position);
                usr.Add("Role", Role);
                resp.Add(usr);
            }
            dr.Close();
            return resp;

        }
    }
}
