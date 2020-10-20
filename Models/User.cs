using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AS_LoginRegistration.Models
{
    public class User
    {
        [Key]
        public int UserID {get;set;}

        [Required]
        [MinLength(2)]
        public string FirstName {get;set;}

        [Required]
        [MinLength(2)]
        public string LastName {get;set;}

        [Required]
        public string Email {get;set;}

        [Required]
        [DataType(DataType.Date)]
        public DateTime DoB {get;set;}

        [Required]
        [DataType(DataType.Password)]
        [MinLength(6)]
        public string Password {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        [NotMapped]
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string Confirm {get;set;}


    }
}