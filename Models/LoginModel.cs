
namespace CittaLogin.Models
{
    public class LoginModel
    {

        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public IFormFile ProfileImage { get; set; }
        public string ProfileImagePath { get; set; } = "/Image/defaultlogo.png";
        public string CompanyName { get; set; } = "CittaNuvola";

    }
}