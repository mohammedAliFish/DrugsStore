

using System.ComponentModel.DataAnnotations;
using System;

namespace task1.Model.Entities
{
    public class Item
    {
        [Key]
        public Guid ItemGUID { get; set; }

        [Display(Name = "   اسم العنصر")]
        public string ItemName { get; set; }

        [Display(Name = "  رمز العنصر")]
        public string ItemCode { get; set; }

        [Display(Name = "  وصف العنصر")]
        public string ItemDescription { get; set; }


       

        [Display(Name = "   التصنيف ")]
        public Category Category { get; set; }
        [Display(Name = "   الشركه")]
        public Company Company { get; set; }

    }
}
