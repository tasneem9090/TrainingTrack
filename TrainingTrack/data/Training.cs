using NuGet.DependencyResolver;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingTrack.data
{
    [Table("Trainings")]
    public class Training
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int? TrainerId { get; set; }
        public Trainer Trainer { get; set; }

        public List<Enrollment> Enrollments { get; set; }


        public List<Survey> Surveys { get; set; }
    }
}
