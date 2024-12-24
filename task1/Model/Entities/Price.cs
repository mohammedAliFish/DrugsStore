

using System;
using System.ComponentModel.DataAnnotations;

namespace task1.Model.Entities
{
    public class Price
    {
        [Key]
        public Guid PriceGUID { get; set; }

        [Display(Name = "   اسم العنصر")]
        public Item Item { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "السعر يجب أن يكون قيمة موجبة")]
        [Display(Name ="سعر العنصر")]
         public int ItemPrice { get; set; }
        
    }
}
