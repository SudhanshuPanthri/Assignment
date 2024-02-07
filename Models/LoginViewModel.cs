using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter a valid Email-Address")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
