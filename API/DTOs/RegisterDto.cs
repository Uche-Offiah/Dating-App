using System;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required] public string username {get; set;}
        [Required] public string KnownAs {get; set;}
        [Required] public string Gender {get; set;}
        [Required] public DateTime DateOfBirth {get; set;}
        [Required] public string City {get; set;}
        [Required] public string Country {get; set;}

        [Required]
        [StringLength(8, MinimumLength =3)]
        public string password {get; set;}
    }
}