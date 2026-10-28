using AutoMapper;
using System.ComponentModel.DataAnnotations;
using TrainingTrack.data;

namespace TrainingTrack.Models
{
    //[AutoMap(typeof(Book), ReverseMap = true)]

    public class BookModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
