using System.ComponentModel.DataAnnotations;

namespace CittaLogin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email or phone number is required")]
        [Display(Name = "Email or Phone")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Invalid phone number format")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters")]
        public string Password { get; set; }

        public IFormFile ProfileImage { get; set; }
        public string ProfileImagePath { get; set; } = "/Image/defaultlogo.png";
        public string CompanyName { get; set; } = "CittaNuvola";
        // public string ErrorMessage { get; set; }
    }
}