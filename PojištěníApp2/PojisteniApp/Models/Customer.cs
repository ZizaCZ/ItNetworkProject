using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PojisteniApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Display(Name = "Jméno")]
        [Required(ErrorMessage = "Je nutné zadat jméno")]
        public string Name { get; set; } = "";
        [Display(Name = "Příjmení")]
        [Required(ErrorMessage = "Je nutné zadat příjmení")]
        public string SurName { get; set; } = "";
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Musíte zadat Email")]
        [EmailAddress]
        public string Email { get; set; } = "";
        [Display(Name = "Telefon")]
        [Phone]
        public string? Phone { get; set; } = "";
        [Display(Name = "Ulice a číslo popisné")]
        [Required(ErrorMessage = "Je nutné zadat Ulici a číslo popisné")]
        public string Address { get; set; } = "";
        [Display(Name = "Město")]
        [Required(ErrorMessage = "Musíte zadat město")]
        public string City { get; set; } = "";
        [Display(Name = "PSČ")]
        [Required(ErrorMessage = "Musíte zadat PSČ")]
        public string PSC { get; set; } = "";
        [NotMapped]
        public virtual List<Insurance>? Insurances { get; set; }
    }
}
