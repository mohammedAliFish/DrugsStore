using System;
using System.Collections.Generic;
using System.Data;
using task1.Model.Entities;


namespace task1.Data
{
    public class CompanyRepository
    {
        public List<Company> GetCompanies()
        {
         
            DataTable dt = sqlHelper.ExecuteStoredProcedure("CompanyGet");

            
            List<Company> companies = new List<Company>();
            foreach (DataRow row in dt.Rows)
            {
                companies.Add(new Company
                {
                    CompanyGuid = Guid.Parse(row["CompanyGUID"].ToString()),
                    CompanyName = row["CompanyName"].ToString()
                });
            }
            return companies;
        }
    }
}
