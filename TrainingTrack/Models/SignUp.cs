using System.ComponentModel.DataAnnotations;

namespace TrainingTrack.Models
{
    public class SignUp
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        public string Password { get; set; }
        [Compare("Password")]
        public string  ConfirmPassword { get; set; }
    }
}
