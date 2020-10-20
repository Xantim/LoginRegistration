using System;
using System.ComponentModel.DataAnnotations;

namespace AS_LoginRegistration.Models
{
    public class LUser
    {
        [Required]
        [EmailAddress]
        public string LEmail {get;set;}

        [Required]
        [DataType(DataType.Password)]
        [MinLength(6)]
        public string LPassword {get;set;}
    }
}