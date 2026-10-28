using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingTrack.data
{
    [Table("Nationalitis")]
    public class Nationality
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Trainee> Trainee { get; set; }
    }
}
