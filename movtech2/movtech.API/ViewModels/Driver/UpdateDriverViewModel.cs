using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace movtech.API.ViewModels.Driver
{
    public class UpdateDriverViewModel
    {
        [Required(ErrorMessage = "Preencha este campo!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Preencha este campo!")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Preencha este campo!")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Preencha este campo!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha este campo!")]
        public string Address { get; set; }     

        [Required(ErrorMessage = "Preencha este campo!")]
        public string CNHCategory { get; set; }
    }
}
