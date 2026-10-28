using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingTrack.data
{
    [Table("Trainers")]
    public class Trainer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateofBirth { get; set; }
        public string Phone { get; set; }

        public string address { get; set; }
        public string? Email { get; set; }

        public List<DailyReport> DailyReport { get; set; }


        public List<BookDistribution> BookDistribution { get; set; }

        public List<Training> Training { get; set; }
    }
}
