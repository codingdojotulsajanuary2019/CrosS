using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurveywVal.Models
{
    public class User
    {
        [Required (ErrorMessage="Name connot be empty")]
        [MinLength(2, ErrorMessage="Name must be longer than 2 characters."), ]
        public string Name {get; set;}

        [Required]
        public string Location {get; set;}

        [Required]
        public string Language {get; set;}

        [MinLength(20, ErrorMessage="Comment must be more than 20 characters.")]
        public string Comment {get; set;}
    }
}