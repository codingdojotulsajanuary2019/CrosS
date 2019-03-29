using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace loginRegistration.Models
{
    public class User
    {
        [Key]
       public int user_id {get;set;}
       [Required(ErrorMessage="First Name is Required!")]
       [MinLength(2, ErrorMessage="First Name must be at least 2 characters!")]
       public string FirstName {get;set;}
       [Required(ErrorMessage="First Name is Required!")]
       [MinLength(2, ErrorMessage="Last Name must be at least 2 characters!")]
       public string LastName {get;set;}
       [Required]
       [EmailAddress]
       public string Email {get;set;}
       [Required]
       [MinLength(8)]
       public string Password {get;set;}
        [Required]
        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
       public string Confirm {get;set;}
       public DateTime created_at {get;set;} = DateTime.Now;
       public DateTime updated_at {get;set;} = DateTime.Now;
    }
}