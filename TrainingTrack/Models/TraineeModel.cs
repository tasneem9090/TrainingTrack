using AutoMapper;
using System.ComponentModel.DataAnnotations;
using TrainingTrack.data;

namespace TrainingTrack.Models
{
    //[AutoMap(typeof(Trainee), ReverseMap = true)]

    public class TraineeModel
    {
       
            public int Id { get; set; }
            [Required]
            public string Name { get; set; }

            [Required]
            [RegularExpression(@"07(7|8|9)\d{7}")]
            public string Phone { get; set; }
            [Required]
            public string Gender { get; set; }
            [Required]


            public int NationalityId { get; set; }
            public NationalityModel Nationality { get; set; }

        //public bool ReceivedBook { get; set; }
    }
    }

