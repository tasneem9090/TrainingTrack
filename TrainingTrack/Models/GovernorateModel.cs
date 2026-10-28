using AutoMapper;
using System.ComponentModel.DataAnnotations;
using TrainingTrack.data;

namespace TrainingTrack.Models
{
    //[AutoMap(typeof(Governorate), ReverseMap = true)]

    public class GovernorateModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
