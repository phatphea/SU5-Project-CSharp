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

        //load all main request by its number
        public List<Dictionary<string, object>> LoadAllRequestByNo(String mainReqNo, String ActiveOrInactiveRequest)
        {
            List<Dictionary<string, object>> resp = new List<Dictionary<string, object>>();
            //logic get data from database tblUser
            OleDbCommand cmd = new OleDbCommand("Select Req_Type, MainReq_No, Created_Date, Req_Desc, UserName, Endorsed_By, Approved_By, Reason, Status, Shipping_Site, Shipping_Address, Amount_BefDiscount, Discount, Base_Amount, Tax_Amount, Total_Amount, r.Is_Deactivated From [Requests] As r Inner JOIN [User] As u ON r.UserID=u.UserID where r.MainReq_No='"+mainReqNo+"' and r.Is_Deactivated='" + ActiveOrInactiveRequest + "' order by Req_Id asc", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string Req_Type = dr["Req_Type"].ToString();
                string MainReq_No = dr["MainReq_No"].ToString();
                string Status = dr["Status"].ToString();
                string Created_Date = dr["Created_Date"].ToString();
                string Req_Desc = dr["Req_Desc"].ToString();
                string Shipping_Site = dr["Shipping_Site"].ToString();
                string Shipping_Address = dr["Shipping_Address"].ToString();
                string Requested_By = dr["UserName"].ToString();
                string Endorsed_By = dr["Endorsed_By"].ToString();
                string Approved_By = dr["Approved_By"].ToString();
                string Reason = dr["Reason"].ToString();
                string Amount_BefDiscount = dr["Amount_BefDiscount"].ToString();
                string Discount = dr["Discount"].ToString();
                string Base_Amount = dr["Base_Amount"].ToString();
                string Tax_Amount = dr["Tax_Amount"].ToString();
                string Total_Amount = dr["Total_Amount"].ToString();
                string Is_Deactivated = dr["Is_Deactivated"].ToString();
                Dictionary<string, object> usr = new Dictionary<string, object>();
                usr.Add("BU", Req_Type);
                usr.Add("MainReq_No", MainReq_No);
                usr.Add("Status", Status);
                usr.Add("Created_Date", Created_Date);
                usr.Add("Req_Desc", Req_Desc);
                usr.Add("Shipping_Site", Shipping_Site);
                usr.Add("Shipping_Address", Shipping_Address);
                usr.Add("Requested_By", Requested_By);
                usr.Add("Endorsed_By", Endorsed_By);
                usr.Add("Approved_By", Approved_By);
                usr.Add("Reason", Reason);
                usr.Add("Amount_BefDiscount", Amount_BefDiscount);
                usr.Add("Discount", Discount);
                usr.Add("Base_Amount", Base_Amount);
                usr.Add("Tax_Amount", Tax_Amount);
                usr.Add("Total_Amount", Total_Amount);
                usr.Add("Is_Deactivated", Is_Deactivated);
                resp.Add(usr);
            }
            dr.Close();
            return resp;

        }

        //load request detail filter by main request no
        public List<Dictionary<string, object>> LoadAllRequestDetails(String mainReqNo)
        {
            List<Dictionary<string, object>> resp = new List<Dictionary<string, object>>();
            //logic get data from database tblUser
            OleDbCommand cmd = new OleDbCommand("Select DetailReq_No, Purchase_Class, rd.Product_No, p.Product_Name, Site, Qty_Order, Unit_Price, rd.Amount_BefDiscount, rd.Discount, rd.Base_Amount, rd.Tax_Amount, rd.Total_Amount, rd.Req_Desc, rd.Is_Deactivated  From ([Request_Details] As rd Inner JOIN [Requests] As r ON rd.MainReq_No=r.MainReq_No) INNER JOIN [Products] AS p ON rd.Product_No = p.Product_No where rd.MainReq_No='" + mainReqNo + "' order by rd.Req_Id asc", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string DetailReq_No = dr["DetailReq_No"].ToString();
                string Purchase_Class = dr["Purchase_Class"].ToString();
                string Product_No = dr["Product_No"].ToString();
                string Product_Name = dr["Product_Name"].ToString();
                string Site = dr["Site"].ToString();
                string Qty_Order = dr["Qty_Order"].ToString();
                string Unit_Price = dr["Unit_Price"].ToString();
                string Amount_BefDiscount = dr["Amount_BefDiscount"].ToString();
                string Discount = dr["Discount"].ToString();
                string Base_Amount = dr["Base_Amount"].ToString();
                string Tax_Amount = dr["Tax_Amount"].ToString();
                string Total_Amount = dr["Total_Amount"].ToString();
                string Req_Desc = dr["Req_Desc"].ToString();
                string Is_Deactivated = dr["Is_Deactivated"].ToString();

                Dictionary<string, object> req = new Dictionary<string, object>();
                req.Add("DetailReq_No", DetailReq_No);
                req.Add("Purchase_Class", Purchase_Class);
                req.Add("Product_No", Product_No);
                req.Add("Product_Name", Product_Name);
                req.Add("Site", Site);
                req.Add("Qty_Order", Qty_Order);
                req.Add("Unit_Price", Unit_Price);
                req.Add("Amount_BefDiscount", Amount_BefDiscount);
                req.Add("Discount", Discount);
                req.Add("Base_Amount", Base_Amount);
                req.Add("Tax_Amount", Tax_Amount);
                req.Add("Total_Amount", Total_Amount);
                req.Add("Req_Desc", Req_Desc);
                req.Add("Is_Deactivated", Is_Deactivated);
                resp.Add(req);
            }
            dr.Close();
            return resp;

        }

        public Boolean isDuplicate(String mainReqNo)
        {
            OleDbCommand cmd = new OleDbCommand(" select * from [Requests] where MainReq_No='" + mainReqNo + "' ", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            Boolean test = dr.Read();
            dr.Close();
            if (test == true)
            {
                return true;
            }
            return false;
        }

        // Method to get the last generated code from the database
        public string GetLastCode(String BU, String createdDate)
        {
            string query = "SELECT TOP 1 MainReq_No FROM [Requests] WHERE MainReq_No LIKE 'PQ-" + BU + "-' & Format('" + createdDate + "', 'yyyy') & '/' & Format('" + createdDate+ "', 'MM') & '-%' ORDER BY Req_Id DESC ";
            OleDbCommand cmd = new OleDbCommand(query, Program.con);
            object result = cmd.ExecuteScalar();
            return result != null ? result.ToString() : null;
        }

        public long getUserID(String usrName)
        {
            OleDbCommand cmd = new OleDbCommand(" select UserID from [User] where UserName='" + usrName + "' ", Program.con);
            int usrId = Convert.ToInt32(cmd.ExecuteScalar());
            return usrId;
        }
        public Boolean addMainRequest(String mainReqNo, String reqType, String createdDate, String Desc, String usrID, String endorsedBy, String approvedBy, String reason, String shippingSite, String Address)
        {
            OleDbCommand cmd = new OleDbCommand(" INSERT INTO [Requests](MainReq_No, Req_Type, Created_Date, Req_Desc, UserID, Endorsed_By, Approved_By, Reason, Shipping_Site, Shipping_Address) VALUES('"+mainReqNo+"', '" + reqType + "','" + createdDate + "','" + Desc + "'," + usrID + ",'" + endorsedBy + "','" + approvedBy + "','" + reason + "', '"+shippingSite+"', '"+Address+"') ", Program.con);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                return true;
            }
            return false;
        }
        public Boolean updateMainRequest(String mainReqNo, String createdDate, String Desc, String usrID, String endorsedBy, String approvedBy, String reason, String shippingSite, String Address)
        {
            OleDbCommand cmd = new OleDbCommand(" update [Requests] set Created_Date='" + createdDate + "', Req_Desc='" + Desc + "', UserID=" + usrID + ", Endorsed_By='" + endorsedBy + "', Approved_By='" + approvedBy + "', Reason='" + reason + "', Shipping_Site='"+shippingSite+ "', Shipping_Address='"+Address+ "' where MainReq_No = '" + mainReqNo + "' ", Program.con);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                return true;
            }
            return false;
        }

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
