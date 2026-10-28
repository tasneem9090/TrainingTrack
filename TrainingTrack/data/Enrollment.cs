using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingTrack.data
{
    [Table("Enrollments")]
    [PrimaryKey(nameof(TraineeId), nameof(TrainingId))]
    public class Enrollment
    {
        public int Id { get; set; }
        public string Name { get; set; }
   
        public DateTime RegistrationDate { get; set; }

        public int TraineeId { get; set; }
        public Trainee Trainee { get; set; }

        public int TrainingId { get; set; }
        public Training Training { get; set; }

    }
}
