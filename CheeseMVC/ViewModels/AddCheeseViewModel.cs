using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public CheeseType Type { get; set; }

        public List<SelectListItem> CheeseTypes { get; set; }

        public AddCheeseViewModel()
        {
            CheeseTypes = new List<SelectListItem>();
            
            CheeseTypes.Add(new SelectListItem //Create drop-down list options for the 3 types of cheese.
            {
                Value = ((int)CheeseType.Hard).ToString(),
                Text = CheeseType.Hard.ToString()
            });

            CheeseTypes.Add(new SelectListItem //It is possible to LOOP through the options for Type to reduce the code.
            {
                Value = ((int)CheeseType.Soft).ToString(),
                Text = CheeseType.Soft.ToString()
            });

            CheeseTypes.Add(new SelectListItem 
            {
                Value = ((int)CheeseType.Fake).ToString(),
                Text = CheeseType.Fake.ToString()
            });
        }
    }
}
