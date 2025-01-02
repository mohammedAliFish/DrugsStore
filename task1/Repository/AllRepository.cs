

using System.Collections.Generic;
using System.Data;
using System;
using task1.Model.Entities;
using System.Data.SqlClient;

namespace task1.Repository
{
    public class AllRepository
    {
        public List<All> GetAllData()
        {
            try
            {
                DataTable dataTable = sqlHelper.ExecuteStoredProcedure("GetAllTables");
                List<All> allData = new List<All>();

                foreach (DataRow row in dataTable.Rows)
                {
                    allData.Add(new All
                    {
                        ItemGUID = Guid.Parse(row["ItemGUID"].ToString()),
                        ItemName = row["ItemName"].ToString(),
                        ItemCode = row["ItemCode"].ToString(),
                        ItemDescription = row["ItemDescription"].ToString(),
                        
                        CompanyCode = row["CompanyCode"].ToString(),
                        CompanyName = row["CompanyName"].ToString(),
                    
                        CategoryName = row["CategoryName"].ToString(),
                        ItemPrice = Convert.ToDecimal(row["Item_Price"]),
                        WholesalePrice = Convert.ToDecimal(row["Wholesale_Price"]),
                        DistributorPrice = Convert.ToDecimal(row["Distributor_Price"])
                    });
                }

                return allData;
            }
            catch (Exception ex)
            {
                throw new Exception("حدث خطأ أثناء جلب البيانات", ex);
            }
        }
        public List<Company> GetCompanies()
        {
            try
            {
                DataTable dt = sqlHelper.ExecuteStoredProcedure("CompanyGet"); 
                var companies = new List<Company>();

                foreach (DataRow row in dt.Rows)
                {
                    companies.Add(new Company
                    {
                        CompanyGuid = Guid.Parse(row["CompanyGUID"].ToString()),
                        CompanyName = row["CompanyName"].ToString(),
                        CompanyCode = row["CompanyCode"].ToString()
                    });
                }

                return companies;
            }
            catch (Exception ex)
            {
                throw new Exception("حدث خطأ أثناء جلب الشركات.", ex);
            }
        }

        public List<Category> GetCategories()
        {
            try
            {
                DataTable dt = sqlHelper.ExecuteStoredProcedure("CategoryGet");
                var categories = new List<Category>();

                foreach (DataRow row in dt.Rows)
                {
                    categories.Add(new Category
                    {
                        CategoryGuid = Guid.Parse(row["CategoryGUID"].ToString()),
                        CategoryName = row["CategoryName"].ToString(),
                        CategoryCode = row["CategoryCode"].ToString()
                    });
                }

                return categories;
            }
            catch (Exception ex)
            {
                throw new Exception("حدث خطأ أثناء جلب التصنيفات.", ex);
            }
        }

        public List<All> FilterData(string itemName, string categoryName, string companyName)
        {
            try
            {
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@ItemName", string.IsNullOrEmpty(itemName) ? (object)DBNull.Value : itemName),
                    new SqlParameter("@CategoryName", string.IsNullOrEmpty(categoryName) ? (object)DBNull.Value : categoryName),
                    new SqlParameter("@CompanyName", string.IsNullOrEmpty(companyName) ? (object)DBNull.Value : companyName)
                };

                DataTable dt = sqlHelper.ExecuteStoredProcedure("FilterItems", parameters.ToArray());

                var allData = new List<All>();
                foreach (DataRow row in dt.Rows)
                {
                    allData.Add(new All
                    {
                        ItemGUID = Guid.Parse(row["ItemGUID"].ToString()),
                        ItemName = row["ItemName"].ToString(),
                        ItemCode = row["ItemCode"].ToString(),
                        ItemDescription = row["ItemDescription"].ToString(),
                        CategoryCode = row["CategoryCode"].ToString(),
                        CategoryName = row["CategoryName"].ToString(),
                        CompanyCode = row["CompanyCode"].ToString(),
                        CompanyName = row["CompanyName"].ToString(),
                        ItemPrice = Convert.ToDecimal(row["Item_Price"]),
                        WholesalePrice = Convert.ToDecimal(row["Wholesale_Price"]),
                        DistributorPrice = Convert.ToDecimal(row["Distributor_Price"])
                    });
                }
                Console.WriteLine(allData);

                return allData;
            }
            catch (Exception ex)
            {
                throw new Exception("حدث خطأ أثناء جلب البيانات.", ex);
            }
        }
    }
}
