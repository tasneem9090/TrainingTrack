using AutoMapper;
using System.ComponentModel.DataAnnotations;
using TrainingTrack.data;

namespace TrainingTrack.Models
{
    //[AutoMap(typeof(Training), ReverseMap = true)]
    public class TrainingModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public int TrainerId { get; set; }
        public TrainerModel Trainer { get; set; }
    }
}
