using AutoMapper;
using System.ComponentModel.DataAnnotations;
using TrainingTrack.data;

namespace TrainingTrack.Models
{
    //[AutoMap(typeof(Trainer), ReverseMap = true)]

    public class TrainerModel
    {
        public int Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }

        public DateTime DateofBirth { get; set; }
        [Required]
        [RegularExpression(@"07(7|8|9)\d{7}")]
        public string? Phone { get; set; }
        [Required]
        public string? address { get; set; }
      
        public string? Email { get; set; }
    }
}
