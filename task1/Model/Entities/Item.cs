

using System.ComponentModel.DataAnnotations;
using System;

namespace task1.Model.Entities
{
    public class Item
    {
        [Key]
        public Guid ItemGUID { get; set; }

        [Required]
        [MaxLength(200)]
        [Display(Name = "   اسم العنصر")]
        public string ItemName { get; set; }

        [MaxLength(40)]
        [Display(Name = "  رمز العنصر")]
        public string ItemCode { get; set; }

        [MaxLength(80)]
        [Display(Name = "  وصف العنصر")]
        public string ItemDescription { get; set; }


       

        [Display(Name = "   التصنيف ")]
        [Required]
        public Category Category { get; set; }
        [Display(Name = "   الشركه")]
        public Company Company { get; set; }

      

    }
}
