using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingTrack.data
{
    [Table("Attendances")]
    public class Attendance
    {
        public int Id { get; set; }

        public int TraineeId { get; set; }
        public Trainee Trainee { get; set; }

        public DateTime Date { get; set; }

        public bool IsPresent { get; set; }

        public string Notes { get; set; }

    }
}
