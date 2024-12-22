using System;
using System.Collections.Generic;
using System.Data;

using task1.Model.Entities;

namespace task1.Data
{
    public class CategoryRepository
    {
        public List<Category> GetCategories()
        {
           
            DataTable dt = sqlHelper.ExecuteStoredProcedure("CategoryGet");

            
            List<Category> categories = new List<Category>();
            foreach (DataRow row in dt.Rows)
            {
                categories.Add(new Category
                {
                    CategoryGuid = Guid.Parse(row["CategoryGUID"].ToString()),
                    CategoryName = row["CategoryName"].ToString()
                });
            }
            return categories;
        }
    }
}
