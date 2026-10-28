using AutoMapper;
using System.ComponentModel.DataAnnotations;
using TrainingTrack.data;

namespace TrainingTrack.Models
{
    //[AutoMap(typeof(DailyReport), ReverseMap = true)]
    public class DailyReportModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int TrainerId { get; set; }
        [Required]
        public IFormFile image { get; set; }
        public string? imgeName { get; set; }

        public string? ContentType { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public string Day { get; set; }
        [Required]
        public string Notes { get; set; }

        public TrainerModel Trainer { get; set; }
    }
}
