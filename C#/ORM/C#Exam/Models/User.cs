using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CExam.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}
        [Required]
       public string Name {get;set;}
       [Required]
       public string Alias {get;set;}
       [Required]
       [EmailAddress]
       public string Email {get;set;}
       [Required]
       [MinLength(8)]
       public string Password {get;set;}
       [NotMapped]
       [Compare("Password")]
       public string Confirm {get;set;}
       public DateTime CreatedAt {get;set;} = DateTime.Now;
       public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
    public class Users
    {
        public List<User> theUsers {get;set;}
    }
}