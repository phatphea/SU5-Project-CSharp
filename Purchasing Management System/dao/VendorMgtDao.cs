using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchasing_Management_System.dao
{
    internal class VendorMgtDao
    {
        public List<Dictionary<string, object>> LoadAllVendors ()
        {
            List<Dictionary<string, object>> resp = new List<Dictionary<string, object>>();
            //logic get data from database tblUser
            OleDbCommand cmd = new OleDbCommand("select Vendor_Id, Vendor_No, Vendor_Name, Vendor_NameKH, Vendor_Class, Address, Email, Phone_Number,Vattin_No,Is_Taxable  from [Vendor] order by Vendor_Id asc", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string Vendor_Id = dr["Vendor_Id"].ToString();
                string Vendor_No = dr["Vendor_No"].ToString();
                string Vendor_Name = dr["Vendor_Name"].ToString();
                string Vendor_NameKH = dr["Vendor_NameKH"].ToString();
                string Vendor_Class = dr["Vendor_Class"].ToString();
                string Address = dr["Address"].ToString();
                string Email = dr["Email"].ToString();
                string Phone_Number = dr["Phone_Number"].ToString();
                string Vattin_No = dr["Vattin_No"].ToString();
                string Is_Taxable = dr["Is_Taxable"].ToString();
                Dictionary<string, object> usr = new Dictionary<string, object>();
                usr.Add("Vendor_Id", Vendor_Id);
                usr.Add("Vendor_No", Vendor_No);
                usr.Add("Vendor_Name", Vendor_Name);
                usr.Add("Vendor_NameKH", Vendor_NameKH);
                usr.Add("Vendor_Class", Vendor_Class);
                usr.Add("Address", Address);
                usr.Add("Email", Email);
                usr.Add("Phone_Number", Phone_Number);
                usr.Add("Vattin_No", Vattin_No);
                usr.Add("Is_Taxable", Is_Taxable);
                resp.Add(usr);
            }
            dr.Close();
            return resp;

        }
        public Boolean isDuplicate(String venPhone)
        {

            OleDbCommand cmd = new OleDbCommand(" select Vendor_Id, Vendor_No, Vendor_Name, Vendor_NameKH, Vendor_Class, Address, Email, Phone_Number,Vattin_No,Is_Taxable from [Vendor] where Phone_Number='" + venPhone + "' ", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            Boolean test = dr.Read();
            dr.Close();
            if (test == true)
            {
                return true;
            }
            return false;
        }

        public long addVendor(String venName, String venNameKH, String venClass, String venAddress, String venEmail, String venPhone, String venVattinNo, String isTax)
        {

            OleDbCommand cmd = new OleDbCommand(" INSERT INTO [Vendor](Vendor_No ,Vendor_Name,Vendor_NameKH, Vendor_Class, Address, Email, Phone_Number,Vattin_No,Is_Taxable) VALUES(' ', '" + venName + "','" + venNameKH + "','" + venClass + "','" + venAddress + "','" + venEmail + "','" + venPhone + "','" +venVattinNo+ "','"+isTax+"') ", Program.con);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                //after insert success then get userId by username
                cmd.CommandText = " select Vendor_Id from [Vendor] where Vendor_Name='" + venName + "' and Phone_Number='" + venPhone + "'  ";
                int venId = Convert.ToInt32(cmd.ExecuteScalar());
                return venId;
            }
            return 0;
        }
        public Boolean updateVendor(String venId, String venName, String venNameKH, String venClass, String venAddress, String venEmail, String venPhone, String venVattinNo, String isTax)
        {
            OleDbCommand cmd = new OleDbCommand(" update [Vendor] set Vendor_Name='" + venName + "',Vendor_NameKH='" + venNameKH + "', Vendor_Class='" + venClass + "', Address='" + venAddress + "', Email='" + venEmail + "', Phone_Number='" + venPhone + "', Vattin_No='" +venVattinNo+ "', Is_Taxable='"+isTax+"' where Vendor_Id = " + venId + " ", Program.con);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                return true;
            }
            return false;
        }

        public void updateVendorNo(String venId)
        {
            OleDbCommand cmd = new OleDbCommand(" UPDATE [Vendor] SET Vendor_No = \"VENDOR \" & Format(Vendor_Id, \"000\") WHERE Vendor_Id = " + venId + " ", Program.con);
            cmd.ExecuteNonQuery();
        }

        public Boolean deleteVendor(String venId)
        {
            OleDbCommand cmd = new OleDbCommand(" delete from [Vendor] where Vendor_Id = " + venId + " ", Program.con);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                return true;
            }
            return false;
        }
        public List<Dictionary<string, object>> searchVendorByID(String id)
        {
            List<Dictionary<string, object>> resp = new List<Dictionary<string, object>>();
            //logic get data from database tblUser
            OleDbCommand cmd = new OleDbCommand("select Vendor_Id, Vendor_No, Vendor_Name, Vendor_NameKH, Vendor_Class, Address, Email, Phone_Number,Vattin_No,Is_Taxable from [Vendor] where Vendor_Id=" + id + " order by Vendor_Id asc ", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string Vendor_Id = dr["Vendor_Id"].ToString();
                string Vendor_No = dr["Vendor_No"].ToString();
                string Vendor_Name = dr["Vendor_Name"].ToString();
                string Vendor_NameKH = dr["Vendor_NameKH"].ToString();
                string Vendor_Class = dr["Vendor_Class"].ToString();
                string Address = dr["Address"].ToString();
                string Email = dr["Email"].ToString();
                string Phone_Number = dr["Phone_Number"].ToString();
                string Vattin_No = dr["Vattin_No"].ToString();
                string Is_Taxable = dr["Is_Taxable"].ToString();
                Dictionary<string, object> usr = new Dictionary<string, object>();
                usr.Add("Vendor_Id", Vendor_Id);
                usr.Add("Vendor_No", Vendor_No);
                usr.Add("Vendor_Name", Vendor_Name);
                usr.Add("Vendor_NameKH", Vendor_NameKH);
                usr.Add("Vendor_Class", Vendor_Class);
                usr.Add("Address", Address);
                usr.Add("Email", Email);
                usr.Add("Phone_Number", Phone_Number);
                usr.Add("Vattin_No", Vattin_No);
                usr.Add("Is_Taxable", Is_Taxable);
                resp.Add(usr);
            }
            dr.Close();
            return resp;

        }
        public List<Dictionary<string, object>> searchVendorsByName(String venName)
        {
            List<Dictionary<string, object>> resp = new List<Dictionary<string, object>>();
            //logic get data from database tblUser
            OleDbCommand cmd = new OleDbCommand("select Vendor_Id, Vendor_No, Vendor_Name, Vendor_NameKH, Vendor_Class, Address, Email, Phone_Number,Vattin_No,Is_Taxable from [Vendor] where Vendor_Name Like '%" + venName + "%' order by Vendor_Id asc ", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string Vendor_Id = dr["Vendor_Id"].ToString();
                string Vendor_No = dr["Vendor_No"].ToString();
                string Vendor_Name = dr["Vendor_Name"].ToString();
                string Vendor_NameKH = dr["Vendor_NameKH"].ToString();
                string Vendor_Class = dr["Vendor_Class"].ToString();
                string Address = dr["Address"].ToString();
                string Email = dr["Email"].ToString();
                string Phone_Number = dr["Phone_Number"].ToString();
                string Vattin_No = dr["Vattin_No"].ToString();
                string Is_Taxable = dr["Is_Taxable"].ToString();
                Dictionary<string, object> usr = new Dictionary<string, object>();
                usr.Add("Vendor_Id", Vendor_Id);
                usr.Add("Vendor_No", Vendor_No);
                usr.Add("Vendor_Name", Vendor_Name);
                usr.Add("Vendor_NameKH", Vendor_NameKH);
                usr.Add("Vendor_Class", Vendor_Class);
                usr.Add("Address", Address);
                usr.Add("Email", Email);
                usr.Add("Phone_Number", Phone_Number);
                usr.Add("Vattin_No", Vattin_No);
                usr.Add("Is_Taxable", Is_Taxable);
                resp.Add(usr);
            }
            dr.Close();
            return resp;

        }
    }
}
