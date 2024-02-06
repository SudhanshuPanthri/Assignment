using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class RegisterViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "password does not match")]
        public string confirmPassword { get; set; }
    }
}
