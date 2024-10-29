using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Purchasing_Management_System.dao
{
    internal class BUMgtDao
    {
        public List<Dictionary<string, object>> LoadAllBU(String ActiveOrInactiveBu)
        {
            List<Dictionary<string, object>> resp = new List<Dictionary<string, object>>();
            //logic get data from database tblUser
            OleDbCommand cmd = new OleDbCommand(" select BU_Id, BU_No, BU_Name, BU_NameKH, BU_Description, Is_Deactivated from [Business_Unit] where Is_Deactivated Like '%" + ActiveOrInactiveBu +"%' order by BU_Id asc ", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string BU_Id = dr["BU_Id"].ToString();
                string BU_No = dr["BU_No"].ToString();
                string BU_Name = dr["BU_Name"].ToString();
                string BU_NameKH = dr["BU_NameKH"].ToString();
                string BU_Description = dr["BU_Description"].ToString();
                string Is_Deactivated = dr["Is_Deactivated"].ToString();
                Dictionary<string, object> usr = new Dictionary<string, object>();
                usr.Add("BU_Id", BU_Id);
                usr.Add("BU_No", BU_No);
                usr.Add("BU_Name", BU_Name);
                usr.Add("BU_NameKH", BU_NameKH);
                usr.Add("BU_Description", BU_Description);
                usr.Add("Is_Deactivated", Is_Deactivated);
                resp.Add(usr);
            }
            dr.Close();
            return resp;

        }
        public Boolean isDuplicate(String buName)
        {
            OleDbCommand cmd = new OleDbCommand(" select * from [Business_Unit] where BU_Name='" + buName + "' ", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            Boolean test = dr.Read();
            dr.Close();
            if (test == true)
            {
                return true;
            }
            return false;
        }

        public long addBu(String buNo, String buName, String buNameKH, String buDesc)
        {
            OleDbCommand cmd = new OleDbCommand(" INSERT INTO [Business_Unit] ( BU_No, BU_Name, BU_NameKH, BU_Description) VALUES('" + buNo + "','" + buName + "','" + buNameKH + "','" + buDesc + "') ", Program.con);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                //after insert success then get buId by buName
                cmd.CommandText = " select BU_Id from [Business_Unit] where BU_Name='" + buName + "'";
                int buId = Convert.ToInt32(cmd.ExecuteScalar());
                return buId;
            }
            return 0;
        }

        public Boolean deleteBu(String buId)
        {
            OleDbCommand cmd = new OleDbCommand(" delete from [Business_Unit] where BU_Id = " + buId + " ", Program.con);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                return true;
            }
            return false;
        }

        public Boolean updateBu(String buId, String buNo, String buName, String buNameKH, String buDesc)
        {
            OleDbCommand cmd = new OleDbCommand(" update [Business_Unit] set BU_No='" + buNo + "', BU_Name='" + buName + "', BU_NameKH='" + buNameKH + "', BU_Description='" + buDesc + "' where BU_Id=" + buId + " ", Program.con);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                return true;
            }
            return false;
        }

        public List<Dictionary<string, object>> searchUserByID(String buNo, String ActiveOrInactiveBU)
        {
            List<Dictionary<string, object>> resp = new List<Dictionary<string, object>>();
            //logic get data from database tblUser
            OleDbCommand cmd = new OleDbCommand("select BU_Id, BU_No, BU_Name, BU_NameKH, BU_Description, Is_Deactivated from [Business_Unit] where BU_No='"+buNo+"' and  Is_Deactivated Like '%" + ActiveOrInactiveBU + "%' Order by BU_Id asc", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string BU_Id = dr["BU_Id"].ToString();
                string BU_No = dr["BU_No"].ToString();
                string BU_Name = dr["BU_Name"].ToString();
                string BU_NameKH = dr["BU_NameKH"].ToString();
                string BU_Description = dr["BU_Description"].ToString();
                string Is_Deactivated = dr["Is_Deactivated"].ToString();
                Dictionary<string, object> usr = new Dictionary<string, object>();
                usr.Add("BU_Id", BU_Id);
                usr.Add("BU_No", BU_No);
                usr.Add("BU_Name", BU_Name);
                usr.Add("BU_NameKH", BU_NameKH);
                usr.Add("BU_Description", BU_Description);
                usr.Add("Is_Deactivated", Is_Deactivated);
                resp.Add(usr);
            }
            dr.Close();
            return resp;
        }
        public List<Dictionary<string, object>> searchUsersByusrName(String buName, String ActiveOrInactiveBU)
        {
            List<Dictionary<string, object>> resp = new List<Dictionary<string, object>>();
            //logic get data from database tblUser
            OleDbCommand cmd = new OleDbCommand("select BU_Id, BU_No, BU_Name, BU_NameKH, BU_Description, Is_Deactivated from [Business_Unit] where BU_Name Like '%" + buName + "%' and  Is_Deactivated Like '%" + ActiveOrInactiveBU + "%' Order by BU_Id asc ", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string BU_Id = dr["BU_Id"].ToString();
                string BU_No = dr["BU_No"].ToString();
                string BU_Name = dr["BU_Name"].ToString();
                string BU_NameKH = dr["BU_NameKH"].ToString();
                string BU_Description = dr["BU_Description"].ToString();
                string Is_Deactivated = dr["Is_Deactivated"].ToString();
                Dictionary<string, object> usr = new Dictionary<string, object>();
                usr.Add("BU_Id", BU_Id);
                usr.Add("BU_No", BU_No);
                usr.Add("BU_Name", BU_Name);
                usr.Add("BU_NameKH", BU_NameKH);
                usr.Add("BU_Description", BU_Description);
                usr.Add("Is_Deactivated", Is_Deactivated);
                resp.Add(usr);
            }
            dr.Close();
            return resp;
        }

        public Boolean deactivateBu(String buId, String deactivate)
        {
            OleDbCommand cmd = new OleDbCommand(" update [Business_Unit] set Is_Deactivated='" + deactivate + "' where BU_Id = " + buId + " ", Program.con);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                return true;
            }
            return false;
        }

        public long countRowsBu(String ActiveOrInactiveBu)
        {
            OleDbCommand cmd = new OleDbCommand("Select count(*) from [Business_Unit] where Is_Deactivated Like '%" + ActiveOrInactiveBu + "%' ", Program.con);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public long countRowsBuByID(String buNo, String ActiveOrInactiveBu)
        {
            OleDbCommand cmd = new OleDbCommand("Select count(*) from [Business_Unit] where BU_No='" + buNo + "' and Is_Deactivated Like '%" + ActiveOrInactiveBu + "%' ", Program.con);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public long countRowsBuByName(String buName, String ActiveOrInactiveBu)
        {
            OleDbCommand cmd = new OleDbCommand("Select count(*) from [Business_Unit] where BU_Name Like '%" + buName + "%' and Is_Deactivated Like '%" + ActiveOrInactiveBu + "%' ", Program.con);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
    }
}
