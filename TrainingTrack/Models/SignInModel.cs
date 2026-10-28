using System.ComponentModel.DataAnnotations;

namespace TrainingTrack.Models
{
    public class SignInModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password{ get; set; }

    }
}
