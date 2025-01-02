using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using task1.Model.Entities;

namespace task1.Data
{
    public class ItemRepository
    {
       

      


        public Guid GetItemGUIDByCode(string itemCode)
        {
            try
            {
                
                var parameters = new SqlParameter[]
                {
                new SqlParameter("@ItemCode", itemCode)
                };

             
                var result = sqlHelper.ExecuteScalar("GetItemGUIDByCode", CommandType.StoredProcedure, parameters);

          
                if (result != null && Guid.TryParse(result.ToString(), out var itemGuid))
                {
                    return itemGuid;
                }

             
                throw new Exception("ItemGUID not found for the given ItemCode.");
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching the ItemGUID.", ex);
            }
        
}

        
        

        public List<Item> GetItems()
        {
            try
            {
                DataTable dt = sqlHelper.ExecuteStoredProcedure("ItemGet");

                List<Item> items = new List<Item>();
                foreach (DataRow row in dt.Rows)
                {
                    items.Add(new Item
                    {
                        ItemGUID = Guid.Parse(row["ItemGUID"].ToString()),
                        ItemName = row["ItemName"].ToString(),
                        ItemCode = row["ItemCode"].ToString(),
                        ItemDescription = row["ItemDescription"].ToString(),
                        Category = new Category
                        {
                            CategoryGuid = Guid.Parse(row["CategoryGUID"].ToString()),
                            CategoryName = row["CategoryName"].ToString()
                        },
                        Company = new Company
                        {
                            CompanyGuid = Guid.Parse(row["CompanyGUID"].ToString()),
                            CompanyName = row["CompanyName"].ToString()
                        }
                    });
                }

                return items;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching items.", ex);
            }



        }

        public void DeleteItem(Guid itemGuid)
        {
            try
            {
                var parameters = new SqlParameter[]
                {
            new SqlParameter("@ItemGUID", itemGuid)
                };

                sqlHelper.ExecuteStoredProcedure("ItemDelete", parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("حذث خطا بالحذف.", ex);
            }
        }


        public void SaveItem(Item item)
    {
        try
        {
                var parameters = new SqlParameter[]
     {
    new SqlParameter("@ItemGUID", item.ItemGUID == Guid.Empty ? (object)DBNull.Value : item.ItemGUID),
    new SqlParameter("@ItemName", item.ItemName ?? (object)DBNull.Value),
    new SqlParameter("@ItemCode", item.ItemCode ?? (object)DBNull.Value),
    new SqlParameter("@ItemDescription", item.ItemDescription ?? (object)DBNull.Value),
    new SqlParameter("@CategoryGUID", item.Category?.CategoryGuid ?? (object)DBNull.Value),
    new SqlParameter("@CompanyGUID", item.Company?.CompanyGuid ?? (object)DBNull.Value)
     };


                sqlHelper.ExecuteStoredProcedure("ItemSave", parameters);
        }
        catch (Exception ex)
        {
           
                throw new Exception("حدثت مشكلة أثناء حفظ العنصر.", ex);
            }
    }





}
}
