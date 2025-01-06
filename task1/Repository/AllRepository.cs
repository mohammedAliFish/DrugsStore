

using System.Collections.Generic;
using System.Data;
using System;
using task1.Model.Entities;
using System.Data.SqlClient;


namespace task1.Repository
{
    public class AllRepository
    {
        

        public DataTable GetFilteredItems(Guid? itemGuid = null, Guid? categoryGuid = null, Guid? companyGuid = null)
        {
            try
            {
                
                var allItemDetails = new List<SqlParameter>
        {
            new SqlParameter("@ItemGUID", (object)itemGuid ?? DBNull.Value),
            new SqlParameter("@CategoryGUID", (object)categoryGuid ?? DBNull.Value),
            new SqlParameter("@CompanyGUID", (object)companyGuid ?? DBNull.Value)
        };

               
                return sqlHelper.ExecuteStoredProcedure("FilterItem", allItemDetails.ToArray());
            }
            catch (Exception ex)
            {
                throw new Exception("خطا", ex);
            }
        }

        public DataTable GetFilteredItemsByName(string itemName = null, string categoryName = null, string companyName = null)
        {
            try
            {
               
                var allItemDetails = new List<SqlParameter>
        {
            new SqlParameter("@ItemName", (object)itemName ?? DBNull.Value),
            new SqlParameter("@CategoryName", (object)categoryName ?? DBNull.Value),
            new SqlParameter("@CompanyName", (object)companyName ?? DBNull.Value)
        };

                
                return sqlHelper.ExecuteStoredProcedure("FilterItemByName", allItemDetails.ToArray());
            }
            catch (Exception ex)
            {
                throw new Exception("خطا", ex);
            }
        }

        public List<Item> GetFilteredItemsName(string itemName = null, string categoryName = null, string companyName = null)
        {
            try
            {
                var allItemDetails = new List<SqlParameter>
        {
            new SqlParameter("@ItemName", (object)itemName ?? DBNull.Value),
            new SqlParameter("@CategoryName", (object)categoryName ?? DBNull.Value),
            new SqlParameter("@CompanyName", (object)companyName ?? DBNull.Value)
        };

                
                DataTable dt = sqlHelper.ExecuteStoredProcedure("FilterItemByName", allItemDetails.ToArray());

               
                var items = new List<Item>();
                foreach (DataRow row in dt.Rows)
                {
                    items.Add(new Item
                    {
                        ItemGUID = Guid.Parse(row["ItemGUID"].ToString()),
                        ItemName = row["ItemName"]?.ToString(),
                        ItemCode = row["ItemCode"]?.ToString(),
                        ItemDescription = row["ItemDescription"]?.ToString(),
                        Category = new Category
                        {
                            CategoryGuid = Guid.Parse(row["CategoryGUID"].ToString()),
                            CategoryName = row["CategoryName"]?.ToString()
                        },
                        Company = new Company
                        {
                            CompanyGuid = Guid.Parse(row["CompanyGUID"].ToString()),
                            CompanyName = row["CompanyName"]?.ToString()
                        }
                    });
                }

                return items;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching filtered items.", ex);
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
       
    }
}
