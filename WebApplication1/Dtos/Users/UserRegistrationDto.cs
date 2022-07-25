using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Dtos.Users;

public class UserRegistrationDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    [Required(ErrorMessage = "Username is required")]
    public string Username { get; set; }
    [Required(ErrorMessage = "password is required")]
    public string Password { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public IEnumerable<string> Roles { get; set; }
}