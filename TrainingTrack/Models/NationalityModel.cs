using AutoMapper;
using System.ComponentModel.DataAnnotations;
using TrainingTrack.data;

namespace TrainingTrack.Models
{
    //[AutoMap(typeof(Nationality), ReverseMap = true)]

    public class NationalityModel
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}
