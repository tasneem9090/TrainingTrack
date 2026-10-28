using AutoMapper;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TrainingTrack.data;

namespace TrainingTrack.Models
{
    //[AutoMap(typeof(BookDistribution), ReverseMap = true)]

    public class BookDistributionModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public int BookId { get; set; }
        [Required]
        public int HallId { get; set; }
        [Required]
        public int GovernorateId { get; set; }
        [Required]
        public int TrainerId { get; set; }
        [Required]
        public int NumberOfCopies { get; set; }

        [Required]
        public DateTime DistributionDate { get; set; }
        public BookModel Book { get; set; }
        public HallModel Hall { get; set; }
        public GovernorateModel Governorate { get; set; }
        public TrainerModel Trainer { get; set; }

    }
}

   
