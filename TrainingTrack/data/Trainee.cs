using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingTrack.data
{
    [Table("Trainees")]
    public class Trainee
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        //public bool ReceivedBook { get; set; }

        public int? NationalityId { get; set; }

        public Nationality Nationality { get; set; }

        public List<Enrollment> Enrollments { get; set; }

    }
}
