using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CExam.Models
{
    public class LoginUser
    {
       [NotMapped]
       [Required]
       [EmailAddress]
       public string Email {get;set;}
       [NotMapped]
       [Required]
       [MinLength(8)]
       public string Password {get;set;}
    }
}