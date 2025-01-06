using System;

using System.ComponentModel.DataAnnotations;


namespace task1.Model.Entities
{
    public class Category
    {
        [Key]
        public Guid CategoryGuid { get; set; }
        [MaxLength(50)]

        [Display(Name = "  رمز التصنيف")]
        public string CategoryCode { get; set; }

        [MaxLength(50)]
        [Display(Name = "اسم التصنيف")]
        public string CategoryName { get; set; }

       
    }
}
