using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchasing_Management_System.dao
{
    internal class ProductMgtDao
    {
        public List<Dictionary<string, object>> LoadAllProducts(String cat, String ActiveOrInactiveProduct)
        {
            List<Dictionary<string, object>> resp = new List<Dictionary<string, object>>();
            //logic get data from database table Category
            OleDbCommand cmd = new OleDbCommand(" Select Product_No, Product_Name, Product_Type, Product_Uom, Product_Description, Category_Name, c.Category_No, p.Is_Deactivated From Products AS p Inner JOIN Category AS c ON p.Category_No=c.Category_No WHERE c.Category_Name Like '%"+cat+"%' and p.Is_Deactivated='"+ActiveOrInactiveProduct+"' Order By Product_Id asc", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string Product_No = dr["Product_No"].ToString();
                string Product_Name = dr["Product_Name"].ToString();
                string Product_Type = dr["Product_Type"].ToString();
                string Product_Uom = dr["Product_Uom"].ToString();
                string Product_Description = dr["Product_Description"].ToString();
                string Category_Name = dr["Category_Name"].ToString();
                string Category_No = dr["Category_No"].ToString();
                string Is_Deactivated = dr["Is_Deactivated"].ToString();
                Dictionary<string, object> usr = new Dictionary<string, object>();
                usr.Add("Product_No", Product_No);
                usr.Add("Product_Name", Product_Name);
                usr.Add("Product_Type", Product_Type);
                usr.Add("Product_Uom", Product_Uom);
                usr.Add("Product_Description", Product_Description);
                usr.Add("Category_Name", Category_Name);
                usr.Add("Category_No", Category_No);
                usr.Add("Is_Deactivated", Is_Deactivated);
                resp.Add(usr);
            }
            dr.Close();
            return resp;
        }
        public List<Dictionary<string, object>> LoadAllCategory()
        {
            List<Dictionary<string, object>> resp = new List<Dictionary<string, object>>();
            //logic get data from database tblUser
            OleDbCommand cmd = new OleDbCommand(" select Category_Name from [Category] where Is_Deactivated='No' order by Category_Id asc ", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string Category_Name = dr["Category_Name"].ToString();
                Dictionary<string, object> cat = new Dictionary<string, object>();
                cat.Add("Category_Name", Category_Name);
                resp.Add(cat);
            }
            dr.Close();
            return resp;
        }

        public Boolean isDuplicate(String proName)
        {

            OleDbCommand cmd = new OleDbCommand(" select * from [Products] where Product_Name='" + proName + "' ", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            Boolean test = dr.Read();
            dr.Close();
            if (test == true)
            {
                return true;
            }
            return false;
        }

        public string getCategoryId(String catName)
        {
            OleDbCommand cmd = new OleDbCommand(" select Category_No from [Category] where Category_Name='" + catName + "' ", Program.con);
            string catNo = Convert.ToString(cmd.ExecuteScalar());
            return catNo;
        }

        public long addProduct(String proName, String typeOfPro, String proUom, String proDesc, String catNo)
        {

            OleDbCommand cmd = new OleDbCommand(" INSERT INTO [Products](Product_No ,Product_Name, Product_Type, Product_Uom, Product_Description, Category_No) VALUES(' ', '" + proName + "','" + typeOfPro + "', '"+proUom+"','" + proDesc + "', '"+catNo+"') ", Program.con);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                //after insert success then get proId by proName
                cmd.CommandText = " select Product_Id from [Products] where Product_Name='" + proName + "' and Is_Deactivated='No' ";
                int catId = Convert.ToInt32(cmd.ExecuteScalar());
                return catId;
            }
            return 0;
        }
        public Boolean updateProduct(String proNo, String proName, String typeOfPro, String proUom, String proDesc, String catNo)
        {
            OleDbCommand cmd = new OleDbCommand(" UPDATE [Products] SET Product_No = 'PD-' & '"+typeOfPro+ "' & '-' & Format(Product_Id, '0000'), Product_Name='" + proName+ "', Product_Type='" + typeOfPro + "', Product_Uom='"+proUom+"', Product_Description='"+proDesc+"', Category_No='"+catNo+"' WHERE Product_No = '" + proNo + "' ", Program.con);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                return true;
            }
            return false;
        }

        public void updateProductNo(String proId, String typeOfProduct)
        {
            OleDbCommand cmd = new OleDbCommand(" UPDATE [Products] SET Product_No = 'PD-' & '"+typeOfProduct+ "' & '-' & Format(Product_Id, '0000') WHERE Product_Id = " + proId + " ", Program.con);
            cmd.ExecuteNonQuery();
        }

        public Boolean deleteProduct(String proNo)
        {
            OleDbCommand cmd = new OleDbCommand(" delete from [Products] where Product_No = '" + proNo + "' ", Program.con);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                return true;
            }
            return false;
        }
        public List<Dictionary<string, object>> searchProductByNo(String proNo, String cat, String ActiveOrInactiveProduct)
        {
            List<Dictionary<string, object>> resp = new List<Dictionary<string, object>>();
            //logic get data from database tblUser
            OleDbCommand cmd = new OleDbCommand(" Select Product_No, Product_Name, Product_Type, Product_Uom, Product_Description, Category_Name, c.Category_No, p.Is_Deactivated From Products AS p Inner JOIN Category AS c ON p.Category_No=c.Category_No WHERE Product_No='"+proNo+"' and c.Category_Name Like '%"+cat+"%' and p.Is_Deactivated='"+ActiveOrInactiveProduct+ "' Order By Product_Id asc ", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string Product_No = dr["Product_No"].ToString();
                string Product_Name = dr["Product_Name"].ToString();
                string Product_Type = dr["Product_Type"].ToString();
                string Product_Uom = dr["Product_Uom"].ToString();
                string Product_Description = dr["Product_Description"].ToString();
                string Category_Name = dr["Category_Name"].ToString();
                string Category_No = dr["Category_No"].ToString();
                string Is_Deactivated = dr["Is_Deactivated"].ToString();
                Dictionary<string, object> usr = new Dictionary<string, object>();
                usr.Add("Product_No", Product_No);
                usr.Add("Product_Name", Product_Name);
                usr.Add("Product_Type", Product_Type);
                usr.Add("Product_Uom", Product_Uom);
                usr.Add("Product_Description", Product_Description);
                usr.Add("Category_Name", Category_Name);
                usr.Add("Category_No", Category_No);
                usr.Add("Is_Deactivated", Is_Deactivated);
                resp.Add(usr);
            }
            dr.Close();
            return resp;
        }
        public List<Dictionary<string, object>> searchProductByName(String proName, String cat, String ActiveOrInactiveProduct)
        {
            List<Dictionary<string, object>> resp = new List<Dictionary<string, object>>();
            //logic get data from database tblUser
            OleDbCommand cmd = new OleDbCommand(" Select Product_No, Product_Name, Product_Type, Product_Uom, Product_Description, Category_Name, c.Category_No, p.Is_Deactivated From Products AS p Inner JOIN Category AS c ON p.Category_No=c.Category_No WHERE Product_Name Like '%" + proName + "%' and c.Category_Name Like '%" + cat + "%' and p.Is_Deactivated='" + ActiveOrInactiveProduct + "' Order By Product_Id asc", Program.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string Product_No = dr["Product_No"].ToString();
                string Product_Name = dr["Product_Name"].ToString();
                string Product_Type = dr["Product_Type"].ToString();
                string Product_Uom = dr["Product_Uom"].ToString();
                string Product_Description = dr["Product_Description"].ToString();
                string Category_Name = dr["Category_Name"].ToString();
                string Category_No = dr["Category_No"].ToString();
                string Is_Deactivated = dr["Is_Deactivated"].ToString();
                Dictionary<string, object> usr = new Dictionary<string, object>();
                usr.Add("Product_No", Product_No);
                usr.Add("Product_Name", Product_Name);
                usr.Add("Product_Type", Product_Type);
                usr.Add("Product_Uom", Product_Uom);
                usr.Add("Product_Description", Product_Description);
                usr.Add("Category_Name", Category_Name);
                usr.Add("Category_No", Category_No);
                usr.Add("Is_Deactivated", Is_Deactivated);
                resp.Add(usr);
            }
            dr.Close();
            return resp;
        }

        public long countRowsProductByName(String proName, String cat, String ActiveOrInactiveProduct)
        {
            OleDbCommand cmd = new OleDbCommand(" Select count(*) From Products AS p Inner JOIN Category AS c ON p.Category_No=c.Category_No WHERE Product_Name Like '%"+proName+"%' and c.Category_Name Like '%"+cat+"%' and p.Is_Deactivated='"+ActiveOrInactiveProduct+"' ", Program.con);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public long countRowsProductByNo(String proNo, String cat, String ActiveOrInactiveProduct)
        {
            OleDbCommand cmd = new OleDbCommand("Select count(*) From Products AS p Inner JOIN Category AS c ON p.Category_No=c.Category_No WHERE Product_No='"+proNo+"' and c.Category_Name Like '%"+cat+"%' and p.Is_Deactivated='"+ActiveOrInactiveProduct+"' ", Program.con);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public long countRowsProduct(String cat, String ActiveOrInactiveProduct)
        {
            OleDbCommand cmd = new OleDbCommand("Select count(*) From Products AS p Inner JOIN Category AS c ON p.Category_No=c.Category_No WHERE c.Category_Name Like '%"+cat+"%' and p.Is_Deactivated='"+ActiveOrInactiveProduct+"' ", Program.con);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public Boolean deactivateProduct(String proNo, String deactivate)
        {
            OleDbCommand cmd = new OleDbCommand(" update [Products] set Is_Deactivated='" + deactivate + "' where Product_No = '" + proNo + "' ", Program.con);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
