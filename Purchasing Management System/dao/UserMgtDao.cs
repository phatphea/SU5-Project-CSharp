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
        public List<Dictionary<string, object>> LoadAllUsers(String bu, String ActiveOrInactiveUser)
        {
            List<Dictionary<string, object>> resp = new List<Dictionary<string, object>>();
            //logic get data from database tblUser
            OleDbCommand cmd = new OleDbCommand(" select UserID, User_No, UserName, UserPassword, UserPosition, UserRole, BU_No, Is_Deactivated from [USER] where BU_No Like '%" +bu+ "%' and Is_Deactivated='" + ActiveOrInactiveUser+"' order by UserID asc ", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string uid = dr["userID"].ToString();
                string uNo = dr["User_No"].ToString();
                string uname = dr["UserName"].ToString();
                string upass = dr["UserPassword"].ToString();
                string UserPosition = dr["UserPosition"].ToString();
                string UserRole = dr["UserRole"].ToString();
                string BU_No = dr["BU_No"].ToString();
                string Is_Deactivated = dr["Is_Deactivated"].ToString();
                Dictionary<string, object> usr = new Dictionary<string, object>();
                usr.Add("uid", uid);
                usr.Add("uNo", uNo);
                usr.Add("uname", uname);
                usr.Add("upass", upass);
                usr.Add("UserPosition", UserPosition);
                usr.Add("UserRole", UserRole);
                usr.Add("BU_No", BU_No);
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

        public long addUser(String usrName, String passWord, String usrPosition, String usrRole, String usrBU)
        {

            OleDbCommand cmd = new OleDbCommand(" INSERT INTO [USER] ( User_No, UserName, UserPassword, UserPosition, UserRole, BU_No) VALUES( ' ','" + usrName + "','" + passWord + "','"+usrPosition+"','"+usrRole+"','"+usrBU+"') ", Program.con);
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
        public void updateUserNo(String uid)
        {
            OleDbCommand cmd = new OleDbCommand(" UPDATE [User] SET User_No = \"ID \" & Format(UserID, \"00000\") WHERE User_No = " + uid + " ", Program.con);
            cmd.ExecuteNonQuery();
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
        public Boolean updateUser(String userId, String usrName, String usrpassWord, String usrPosition, String usrRole, String usrBU)
        {
            OleDbCommand cmd = new OleDbCommand(" update [USER] set UserName='" + usrName + "', UserPassword='" + usrpassWord + "', UserPosition='"+usrPosition+ "', UserRole='" + usrRole+"', BU_No='"+usrBU+"' where User_No = '" + userId + "' ", Program.con);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                return true;
            }
            return false;
        }
        public List<Dictionary<string, object>> searchUserByID(String id, String bu, String ActiveOrInactiveUser)
        {
            List<Dictionary<string, object>> resp = new List<Dictionary<string, object>>();
            //logic get data from database tblUser
            OleDbCommand cmd = new OleDbCommand("select UserID, User_No, UserName, UserPassword, UserPosition, UserRole, BU_No, Is_Deactivated from [USER] where User_No='" + id + "' and  Is_Deactivated='" + ActiveOrInactiveUser + "' and BU_No LIKE '%" + bu + "%' order by UserID asc ", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string uid = dr["userID"].ToString();
                string uNo = dr["User_No"].ToString();
                string uname = dr["UserName"].ToString();
                string upass = dr["UserPassword"].ToString();
                string UserPosition = dr["UserPosition"].ToString();
                string UserRole = dr["UserRole"].ToString();
                string BU_No = dr["BU_No"].ToString();
                string Is_Deactivated = dr["Is_Deactivated"].ToString();
                Dictionary<string, object> usr = new Dictionary<string, object>();
                usr.Add("uid", uid);
                usr.Add("uNo", uNo);
                usr.Add("uname", uname);
                usr.Add("upass", upass);
                usr.Add("UserPosition", UserPosition);
                usr.Add("UserRole", UserRole);
                usr.Add("BU_No", BU_No);
                usr.Add("Is_Deactivated", Is_Deactivated);
                resp.Add(usr);
            }
            dr.Close();
            return resp;

        }
        public List<Dictionary<string, object>> searchUsersByusrName(String usrName, String bu, String ActiveOrInactiveUser)
        {
            List<Dictionary<string, object>> resp = new List<Dictionary<string, object>>();
            //logic get data from database tblUser
            OleDbCommand cmd = new OleDbCommand("select UserID, User_No, UserName, UserPassword, UserPosition, UserRole, BU_No, Is_Deactivated from [USER] where UserName Like '" + usrName + "%' and  Is_Deactivated='" + ActiveOrInactiveUser + "' and BU_No LIKE '%" + bu + "%' order by UserID asc ", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string uid = dr["userID"].ToString();
                string uNo = dr["User_No"].ToString();
                string uname = dr["UserName"].ToString();
                string upass = dr["UserPassword"].ToString();
                string UserPosition = dr["UserPosition"].ToString();
                string UserRole = dr["UserRole"].ToString();
                string BU_No = dr["BU_No"].ToString();
                string Is_Deactivated = dr["Is_Deactivated"].ToString();
                Dictionary<string, object> usr = new Dictionary<string, object>();
                usr.Add("uid", uid);
                usr.Add("uNo", uNo);
                usr.Add("uname", uname);
                usr.Add("upass", upass);
                usr.Add("UserPosition", UserPosition);
                usr.Add("UserRole", UserRole);
                usr.Add("BU_No", BU_No);
                usr.Add("Is_Deactivated", Is_Deactivated);
                resp.Add(usr);
            }
            dr.Close();
            return resp;

        }
        public List<Dictionary<string, object>> LoadAllBU()
        {
            List<Dictionary<string, object>> resp = new List<Dictionary<string, object>>();
            //logic get data from database tblUser
            OleDbCommand cmd = new OleDbCommand(" select BU_No from [Business_Unit] where Is_Deactivated='No' order by BU_Id asc ", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string BU_No = dr["BU_No"].ToString();
                Dictionary<string, object> bu = new Dictionary<string, object>();
                bu.Add("BU_No", BU_No);
                resp.Add(bu);
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
        public long countRowsUser(String bu, String ActiveOrInactiveUser)
        {
            OleDbCommand cmd = new OleDbCommand("Select count(*) from [User] where Is_Deactivated='" + ActiveOrInactiveUser + "' and BU_No LIKE '%" + bu + "%' ", Program.con);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public long countRowsUserByID(String id, String bu, String ActiveOrInactiveUser)
        {
            OleDbCommand cmd = new OleDbCommand("Select count(*) from [User] where User_No='"+id+"' and Is_Deactivated='" + ActiveOrInactiveUser + "' and BU_No LIKE '%" + bu + "%' ", Program.con);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public long countRowsUserByName(String usrName, String bu, String ActiveOrInactiveUser)
        {
            OleDbCommand cmd = new OleDbCommand("Select count(*) from [User] where UserName Like '%" + usrName + "%' and Is_Deactivated='" + ActiveOrInactiveUser + "' and BU_No LIKE '%" + bu + "%' ", Program.con);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }

        public string searchUserRole(String usrName)
        {
            OleDbCommand cmd = new OleDbCommand("Select UserRole from [User] where UserName='"+usrName+"'", Program.con);
            string usr = Convert.ToString(cmd.ExecuteScalar());
            return usr;
        }
    }
}
