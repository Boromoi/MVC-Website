using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeCalculatorWebApp.Models
{
    public class BerekeningenViewModel
    {
        [Required(ErrorMessage = "Start tijd is verplicht")]
        [Display(Name = "StartTijd")]
        public string DateTimeBeginTijd { get; set; }

        [Required(ErrorMessage = "Eind tijd is verplicht")]
        [Display(Name = "EindTijd")]
        public string DateTimeEindTijd { get; set; }

        [Display(Name = "Resultaat")]
        public string Resultaat { get; set; }
    }
}
