using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchasing_Management_System.dao
{
    internal class RequestMgtDao
    {
        public List<Dictionary<string, object>> LoadAllRequest(String ActiveOrInactiveRequest)
        {
            List<Dictionary<string, object>> resp = new List<Dictionary<string, object>>();
            //logic get data from database tblUser
            OleDbCommand cmd = new OleDbCommand("Select Req_Type, MainReq_No, Status, Created_Date, Shipping_Site, Total_Amount, UserName, r.Is_Deactivated From [Requests] As r Inner JOIN [User] As u ON r.UserID=u.UserID where r.Is_Deactivated='" + ActiveOrInactiveRequest+"' order by Req_Id asc", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string Req_Type = dr["Req_Type"].ToString();
                string MainReq_No = dr["MainReq_No"].ToString();
                string Status = dr["Status"].ToString();
                string Created_Date = dr["Created_Date"].ToString();
                string Shipping_Site = dr["Shipping_Site"].ToString();
                string Total_Amount = dr["Total_Amount"].ToString();
                string Requested_By = dr["UserName"].ToString();
                string Is_Deactivated = dr["Is_Deactivated"].ToString();
                Dictionary<string, object> usr = new Dictionary<string, object>();
                usr.Add("BU", Req_Type);
                usr.Add("MainReq_No", MainReq_No);
                usr.Add("Status", Status);
                usr.Add("Created_Date", Created_Date);
                usr.Add("Shipping_Site", Shipping_Site);
                usr.Add("Total_Amount", Total_Amount);
                usr.Add("Requested_By", Requested_By);
                usr.Add("Is_Deactivated", Is_Deactivated);
                resp.Add(usr);
            }
            dr.Close();
            return resp;

        }

        /*public Boolean isDuplicate(String venPhone)
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
        }*/

        /*public long addVendor(String venName, String venNameKH, String venClass, String venAddress, String venEmail, String venPhone, String venVattinNo, String isTax)
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
        }*/
        /*public Boolean updateVendor(String venId, String venName, String venNameKH, String venClass, String venAddress, String venEmail, String venPhone, String venVattinNo, String isTax)
        {
            OleDbCommand cmd = new OleDbCommand(" update [Vendor] set Vendor_Name='" + venName + "',Vendor_NameKH='" + venNameKH + "', Vendor_Class='" + venClass + "', Address='" + venAddress + "', Email='" + venEmail + "', Phone_Number='" + venPhone + "', Vattin_No='" +venVattinNo+ "', Is_Taxable='"+isTax+"' where Vendor_Id = " + venId + " ", Program.con);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                return true;
            }
            return false;
        }*/

        /*public void updateVendorNo(String venId)
        {
            OleDbCommand cmd = new OleDbCommand(" UPDATE [Vendor] SET Vendor_No = \"VENDOR \" & Format(Vendor_Id, \"000\") WHERE Vendor_Id = " + venId + " ", Program.con);
            cmd.ExecuteNonQuery();
        }*/

        public Boolean deleteRequest(String reqNo)
        {
            OleDbCommand cmd1 = new OleDbCommand(" delete from [Request_Details] where MainReq_No = '" + reqNo + "' ", Program.con);
            int count1 = cmd1.ExecuteNonQuery();
            if (count1 > 0)
            {
                OleDbCommand cmd2 = new OleDbCommand(" delete from [Requests] where MainReq_No = '" + reqNo + "' ", Program.con);
                int count2 = cmd2.ExecuteNonQuery();
                if (count2 > 0)
                {
                    return true;
                }
            }
            return false;
        }
        /*public List<Dictionary<string, object>> searchVendorByNo(String venNo, String ActiveOrInactiveVendor)
        {
            List<Dictionary<string, object>> resp = new List<Dictionary<string, object>>();
            //logic get data from database tblUser
            OleDbCommand cmd = new OleDbCommand("select Vendor_Id, Vendor_No, Vendor_Name, Vendor_NameKH, Vendor_Class, Address, Email, Phone_Number,Vattin_No,Is_Taxable,Is_Deactivated from [Vendor] where Vendor_No='" + venNo + "' and Is_Deactivated='"+ActiveOrInactiveVendor+"' order by Vendor_Id asc ", Program.con);
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
                string Is_Deactivated = dr["Is_Deactivated"].ToString();
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
                usr.Add("Is_Deactivated", Is_Deactivated);
                resp.Add(usr);
            }
            dr.Close();
            return resp;

        }*/
        /* public List<Dictionary<string, object>> searchVendorsByName(String venName, String ActiveOrInactiveVendor)
         {
             List<Dictionary<string, object>> resp = new List<Dictionary<string, object>>();
             //logic get data from database tblUser
             OleDbCommand cmd = new OleDbCommand("select Vendor_Id, Vendor_No, Vendor_Name, Vendor_NameKH, Vendor_Class, Address, Email, Phone_Number,Vattin_No,Is_Taxable,Is_Deactivated from [Vendor] where Vendor_Name Like '%"+venName+"%' and Is_Deactivated='"+ActiveOrInactiveVendor+"' order by Vendor_Id asc ", Program.con);
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
                 string Is_Deactivated = dr["Is_Deactivated"].ToString();
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
                 usr.Add("Is_Deactivated", Is_Deactivated);
                 resp.Add(usr);
             }
             dr.Close();
             return resp;

         }*/
        /*public long countRowsVendorByName(String venName, String ActiveOrInactiveVendor)
        {
            OleDbCommand cmd = new OleDbCommand("Select count(*) from [Vendor] where Is_Deactivated='"+ActiveOrInactiveVendor+ "' and vendor_name LIKE '%" + venName + "%'; ", Program.con);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }*/
        /* public long countRowsVendorByNo(String venNo, String ActiveOrInactiveVendor)
         {
             OleDbCommand cmd = new OleDbCommand("Select count(*) from [Vendor] where Vendor_No ='" + venNo+ "' and Is_Deactivated='" + ActiveOrInactiveVendor+"' ", Program.con);
             int count = (int)cmd.ExecuteScalar();
             return count;
         }*/
        public long countRowsRequestByActiveOrInactive(String ActiveOrInactiveRequest)
        {
            OleDbCommand cmd = new OleDbCommand("Select count(*) from [Requests] where Is_Deactivated='" + ActiveOrInactiveRequest + "' ", Program.con);
            int count = (int)cmd.ExecuteScalar();
            if(count == 0)
            {
                return 0;
            }
            return count;
        }
        public Boolean deactivateRequest(String reqNo, String deactivate)
        {
            OleDbCommand cmd1 = new OleDbCommand(" update [Requests] set Is_Deactivated='" + deactivate + "' where MainReq_No = '" + reqNo + "' ", Program.con);
            int count1 = cmd1.ExecuteNonQuery();
            
            OleDbCommand cmd2 = new OleDbCommand(" update [Request_Details] set Is_Deactivated='" + deactivate + "' where MainReq_No = '" + reqNo + "' ", Program.con);
            int count2 = cmd2.ExecuteNonQuery();

            if (count1 > 0 && count2 > 0)
            {
                return true;
            }
            return false;
        }
    }
}
