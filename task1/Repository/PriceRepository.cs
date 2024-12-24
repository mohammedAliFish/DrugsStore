using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using task1.Model.Entities;

namespace task1.Repository
{
    public class PriceRepository
    {


        public List<Price> GetPrices()
        {
            try
            {
                DataTable dt = sqlHelper.ExecuteStoredProcedure("PriceGet");

                List<Price> prices = new List<Price>();
                foreach (DataRow row in dt.Rows)
                {
                    prices.Add(new Price
                    {
                        PriceGUID = row["PriceGUID"] != DBNull.Value ? Guid.Parse(row["PriceGUID"].ToString()) : Guid.Empty,
                        ItemPrice = row["ItemPrice"] != DBNull.Value ? (int)Convert.ToDecimal(row["ItemPrice"]) : 0,
                        Item = new Item
                        {
                            ItemName = row["ItemName"] != DBNull.Value ? row["ItemName"].ToString() : "غير معروف"
                        }
                    });
                }
                Console.WriteLine(prices);

                return prices;
            }
            catch (Exception ex)
            {
                throw new Exception("خطا جلب الاسعار", ex);
            }
        }

        public void SaveOrUpdatePrice(Price price)
        {
            try
            {
                var parameters = new SqlParameter[]
                {
            new SqlParameter("@PriceGUID", price.PriceGUID == Guid.Empty ? (object)DBNull.Value : price.PriceGUID),
            new SqlParameter("@ItemGUID", price.Item.ItemGUID),
            new SqlParameter("@ItemPrice", price.ItemPrice)
                };

                sqlHelper.ExecuteStoredProcedure("PriceSave", parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("حدث خطا", ex);
            }
        }

        public void DeletePrice(Guid priceGuid)
        {
            try
            {
                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@PriceGUID", priceGuid)
                };

                sqlHelper.ExecuteStoredProcedure("PriceDelete", parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("خطأ  حذف السعر.", ex);
            }
        }




    }
}
