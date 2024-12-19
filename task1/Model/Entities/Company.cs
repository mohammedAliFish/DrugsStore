using System;
using System.ComponentModel.DataAnnotations;

namespace task1.Model.Entities
{
    public class Company
    {
        [Key]
        public Guid CompanyGuid { get; set; }

        [Display(Name = "  رمز الشركه")]
        public string CompanyCode { get; set; }

        [Display(Name = "اسم الشركه")]
        public string CompanyName { get; set; }
    }
}
