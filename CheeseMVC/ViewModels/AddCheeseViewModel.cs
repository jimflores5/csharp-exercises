using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class AddCheeseViewModel
    {
        [Required(ErrorMessage ="Please enter the name of a cheese.")]
        [Display(Name = "Name of cheese")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please enter a description for the cheese.")]
        public string Info { get; set; }
    }
}
