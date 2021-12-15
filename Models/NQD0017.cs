using System.ComponentModel.DataAnnotations;

namespace NguyenQuocDat0017.Models
{
    public class NQD0017
    {
        [Key, StringLength(20), Display(Name = "ID")]
        public string NQDId { get; set; }
        [Required, StringLength(50), Display(Name = "Họ và tên")]
        public string NQDName { get; set; }
        [Required, Display(Name = "Giới tính nam")]
        public bool NQDGender { get; set; }
    }
}