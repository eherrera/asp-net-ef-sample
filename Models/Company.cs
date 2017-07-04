using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Display(Name = "RUT")]   
        [Required]
        public string RUT { get; set; }

        [Display(Name = "Nombre")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Dirección")]        
        public string Address { get; set; }

        [Display(Name = "Email")]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        [Display(Name = "Website")]        
        public string Website { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Teléfono")]
        public string Phone { get; set; }

    }
}
