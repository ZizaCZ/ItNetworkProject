using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PojisteniApp.Models
{
    public class Insurance
    {
        [Key]
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        [ForeignKey(name: "CustomerId")]
        public virtual Customer? customer { get; set; }
        [Required(ErrorMessage = "Je nutné zadat částku na pokrytí")]
        [Display(Name = "Částka")]
        public int Amount { get; set; }
        [Required(ErrorMessage = "Zadejte co má smlouva pokrývat")]
        [Display(Name = "Předmět pojištění")]
        public string Subject { get; set; } = "";
        [Required(ErrorMessage = "Je potřeba vyplnit datum od kolikátého smlouva platí")]
        [DataType(DataType.Date)]
        [Display(Name = "Platnost od")]
        public DateTime ValidFrom { get; set; }
        [Required(ErrorMessage = "Je potřeba vyplnit datum do kolikátého smlouva platí")]
        [DataType(DataType.Date)]
        [Display(Name = "Platnost do")]
        public DateTime ValidUntil { get; set; }
        [Display(Name = "Pojištění")]
        public string Option { get; set; }
        [NotMapped]
        public List<SelectListItem> Options { get; private set; }
        public Insurance()
        {
            Option = "1";
            Options = new List<SelectListItem>
            {
                new SelectListItem { Text = "Pojištění majetku",Value="Pojištění majetku",Selected=true},
                new SelectListItem { Text = "Pojištění odpovědnosti zaměstnance",Value="Pojištění odpovědnosti zaměstnance" },
                new SelectListItem {Text="Cestovní pojištění",Value="Cestovní pojištění"},
                new SelectListItem {Text="Životní pojištění",Value="Životní pojištění"},
                new SelectListItem {Text="Zdravotní pojištění",Value="Zdravotní pojištění"}
            };
        }
    }
}
