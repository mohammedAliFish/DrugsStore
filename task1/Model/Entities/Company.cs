using System;
using System.ComponentModel.DataAnnotations;

namespace task1.Model.Entities
{
    public class Company
    {
        [Key]
        public Guid CompanyGuid { get; set; }

        [MaxLength(30)]
        [Display(Name = "  رمز الشركه")]
        public string CompanyCode { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "اسم الشركه")]
        public string CompanyName { get; set; }

       
    }
}
