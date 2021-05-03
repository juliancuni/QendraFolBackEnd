using System.ComponentModel.DataAnnotations;

namespace BackEnd.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 4)]
        public string Password { get; set; }
    }

}