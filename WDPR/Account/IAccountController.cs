using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ReactApp.Account
{
    public class GebruikerLogin
    {
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; init; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; init; }
    }

    // KIJK UIT: classes die een controller extenden moeten ook ControllerBase extenden
    public interface IAccountController
    {
        public Task<object> Registreer(AGebruiker gebruiker, IdentityRole rol); // Moet async zijn
        public Task<IActionResult> Login([FromBody] GebruikerLogin login);
        public Task<IActionResult> Logout([FromBody] AGebruiker gebruiker);
    }
}
