using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingTrack.data
{
    [Table("Halls")]
    public class Hall
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public List<BookDistribution> BookDistribution { get; set; }

    }
}
