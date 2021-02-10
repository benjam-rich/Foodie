using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Foodie.Models
{
    /*Here is the aplication response page for validation and getting and setting the values from the form for the model 
     Notice how it checks to make sure that a phone number comes in a valid format (basically it must be a number)*/
    public class ApplicationResponse
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string RName { get; set; }
        [Required]
        public string FDish { get; set; }
        //The regular expression requires phone input in this format ###-###-#### or  ##########
        [Required] [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PNumber { get; set; }
    }
}
