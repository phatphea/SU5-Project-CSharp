using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchasing_Management_System.dao
{
    internal class CategoryMgtDao
    {
        public List<Dictionary<string, object>> LoadAllCategory(String catClass, String ActiveOrInactiveCategory)
        {
            List<Dictionary<string, object>> resp = new List<Dictionary<string, object>>();
            //logic get data from database tblUser
            OleDbCommand cmd = new OleDbCommand("select Category_No, Category_Class, Category_Name, Category_Types, Category_Desc, Is_Deactivated from [CATEGORY] where Category_Class Like '%" +catClass+ "%' and Is_Deactivated='" + ActiveOrInactiveCategory+"' order by Category_Id asc", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string Category_No = dr["Category_No"].ToString();
                string Category_Class = dr["Category_Class"].ToString();
                string Category_Name = dr["Category_Name"].ToString();
                string Category_Types = dr["Category_Types"].ToString();
                string Category_Desc = dr["Category_Desc"].ToString();
                string Is_Deactivated = dr["Is_Deactivated"].ToString();
                Dictionary<string, object> usr = new Dictionary<string, object>();
                usr.Add("Category_No", Category_No);
                usr.Add("Category_Class", Category_Class);
                usr.Add("Category_Name", Category_Name);
                usr.Add("Category_Types", Category_Types);
                usr.Add("Category_Desc", Category_Desc);
                usr.Add("Is_Deactivated", Is_Deactivated);
                resp.Add(usr);
            }
            dr.Close();
            return resp;
        }

        public Boolean isDuplicate(String catName)
        {

            OleDbCommand cmd = new OleDbCommand(" select * from [Category] where Category_Name='" + catName + "' ", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            Boolean test = dr.Read();
            dr.Close();
            if (test == true)
            {
                return true;
            }
            return false;
        }

        public long addCategory(String catClass, String catName, String catType, String catDesc)
        {

            OleDbCommand cmd = new OleDbCommand(" INSERT INTO [Category](Category_No ,Category_Class, Category_Name, Category_Types, Category_Desc) VALUES(' ', '" + catClass + "','" + catName + "', '"+catType+"','" + catDesc + "') ", Program.con);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                //after insert success then get userId by username
                cmd.CommandText = " select Category_Id from [Category] where Category_Name='" + catName + "' and Category_Class='"+catClass+"' and Is_Deactivated='No'  ";
                int catId = Convert.ToInt32(cmd.ExecuteScalar());
                return catId;
            }
            return 0;
        }
        public Boolean updateCategory(String catNo, String catClass, String catName, String typeOfCategory, String catDesc)
        {
            OleDbCommand cmd = new OleDbCommand(" UPDATE [Category] SET Category_No = 'CAT-' & '" + typeOfCategory + "' & '-' & Format(Category_Id, '0000'), Category_Class='"+catClass+ "', Category_Name='" + catName + "', Category_Types='"+typeOfCategory+"', Category_Desc='"+catDesc+"' WHERE Category_No = '" + catNo + "' ", Program.con);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                return true;
            }
            return false;
        }

        public void updateCategoryNo(String catId, String typeOfCategory)
        {
            OleDbCommand cmd = new OleDbCommand(" UPDATE [Category] SET Category_No = 'CAT-' & '"+typeOfCategory+ "' & '-' & Format(Category_Id, '0000') WHERE Category_Id = " + catId + " ", Program.con);
            cmd.ExecuteNonQuery();
        }

        public Boolean deleteCategory(String catNo)
        {
            OleDbCommand cmd = new OleDbCommand(" delete from [Category] where Category_No = '" + catNo + "' ", Program.con);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                return true;
            }
            return false;
        }
        public List<Dictionary<string, object>> searchCategoryByNo(String catNo, String catClass, String ActiveOrInactiveCategory)
        {
            List<Dictionary<string, object>> resp = new List<Dictionary<string, object>>();
            //logic get data from database tblUser
            OleDbCommand cmd = new OleDbCommand("select Category_No, Category_Class, Category_Name, Category_Types, Category_Desc, Is_Deactivated from [CATEGORY] where Category_No='" + catNo + "' and Category_Class Like '%" + catClass+"%'  and Is_Deactivated='" + ActiveOrInactiveCategory+"' order by Category_Id asc ", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string Category_No = dr["Category_No"].ToString();
                string Category_Class = dr["Category_Class"].ToString();
                string Category_Name = dr["Category_Name"].ToString();
                string Category_Types = dr["Category_Types"].ToString();
                string Category_Desc = dr["Category_Desc"].ToString();
                string Is_Deactivated = dr["Is_Deactivated"].ToString();
                Dictionary<string, object> usr = new Dictionary<string, object>();
                usr.Add("Category_No", Category_No);
                usr.Add("Category_Class", Category_Class);
                usr.Add("Category_Name", Category_Name);
                usr.Add("Category_Types", Category_Types);
                usr.Add("Category_Desc", Category_Desc);
                usr.Add("Is_Deactivated", Is_Deactivated);
                resp.Add(usr);
            }
            dr.Close();
            return resp;
        }
        public List<Dictionary<string, object>> searchCategoryByName(String catName, String catClass, String ActiveOrInactiveCategory)
        {
            List<Dictionary<string, object>> resp = new List<Dictionary<string, object>>();
            //logic get data from database tblUser
            OleDbCommand cmd = new OleDbCommand("select Category_No, Category_Class, Category_Name, Category_Types, Category_Desc, Is_Deactivated from [CATEGORY] where Category_Name Like '%" + catName+ "%' and Category_Class Like '%" + catClass+"%' and Is_Deactivated='" + ActiveOrInactiveCategory +"' order by Category_Id asc ", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string Category_No = dr["Category_No"].ToString();
                string Category_Class = dr["Category_Class"].ToString();
                string Category_Name = dr["Category_Name"].ToString();
                string Category_Types = dr["Category_Types"].ToString();
                string Category_Desc = dr["Category_Desc"].ToString();
                string Is_Deactivated = dr["Is_Deactivated"].ToString();
                Dictionary<string, object> usr = new Dictionary<string, object>();
                usr.Add("Category_No", Category_No);
                usr.Add("Category_Class", Category_Class);
                usr.Add("Category_Name", Category_Name);
                usr.Add("Category_Types", Category_Types);
                usr.Add("Category_Desc", Category_Desc);
                usr.Add("Is_Deactivated", Is_Deactivated);
                resp.Add(usr);
            }
            dr.Close();
            return resp;
        }
        
        public long countRowsCatogoryByName(String catName, String catClass, String ActiveOrInactiveCategory)
        {
            OleDbCommand cmd = new OleDbCommand("Select count(*) from [Category] where Is_Deactivated='"+ActiveOrInactiveCategory+ "' and Category_Name LIKE '%" + catName + "%' and Category_Class Like '%" + catClass+"%' ", Program.con);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public long countRowsCategoryByNo(String catNo, String catClass, String ActiveOrInactiveCategory)
        {
            OleDbCommand cmd = new OleDbCommand("Select count(*) from [Category] where Category_No ='"+catNo+ "' and Category_Class Like '%" + catClass+"%' and Is_Deactivated='" + ActiveOrInactiveCategory +"' ", Program.con);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public long countRowsCatogory(String catClass, String ActiveOrInactiveCategory)
        {
            OleDbCommand cmd = new OleDbCommand("Select count(*) from [Category] where Is_Deactivated='" + ActiveOrInactiveCategory + "' and Category_Class LIKE '%" + catClass + "%' ", Program.con);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public Boolean deactivateCategory(String catNo, String deactivate)
        {
            OleDbCommand cmd = new OleDbCommand(" update [Category] set Is_Deactivated='" + deactivate + "' where Category_No = '" + catNo + "' ", Program.con);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
