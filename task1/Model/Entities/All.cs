

using System.ComponentModel.DataAnnotations;
using System;

namespace task1.Model.Entities
{
    public class All
    {
        [Key]
        public Guid ItemGUID { get; set; }

        [Display(Name = "   اسم العنصر")]
        public string ItemName { get; set; }

        [Display(Name = "  رمز العنصر")]
        public string ItemCode { get; set; }

        [Display(Name = "  وصف العنصر")]
        public string ItemDescription { get; set; }

        //[Key]
        //public Guid CompanyGuid { get; set; }

        [Display(Name = "  رمز الشركه")]
        public string CompanyCode { get; set; }

        [Display(Name = "اسم الشركه")]
        public string CompanyName { get; set; }

        //[Key]
       // public Guid CategoryGuid { get; set; }

        [Display(Name = "  رمز التصنيف")]
        public string CategoryCode { get; set; }

        [Display(Name = "اسم التصنيف")]
        public string CategoryName { get; set; }

        [Display(Name = "سعر الوحدة")]
        public decimal ItemPrice { get; set; }

        [Display(Name = "سعر الجملة")]
        public decimal WholesalePrice { get; set; }

        [Display(Name = "سعر الموزع")]
        public decimal DistributorPrice { get; set; }

    }
}
