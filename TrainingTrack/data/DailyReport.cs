using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingTrack.data
{
    [Table("DailyReports")]
    public class DailyReport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string? ContentType { get; set; }

        public string imgeName { get; set; }
        public string Day { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
    }
}
