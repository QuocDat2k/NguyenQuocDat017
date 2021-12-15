using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NguyenQuocDat017.Models
{
    [Table("CompanyNQD0017")]
    public class CompanyNQD0017
    {
        [Key]
        [Display(Name = "ID Company")]
        public string CompanyId { get; set; }
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
    }
}
