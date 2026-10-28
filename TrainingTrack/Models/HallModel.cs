using AutoMapper;
using System.ComponentModel.DataAnnotations;
using TrainingTrack.data;

namespace TrainingTrack.Models
{
    //[AutoMap(typeof(Hall), ReverseMap = true)]

    public class HallModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
