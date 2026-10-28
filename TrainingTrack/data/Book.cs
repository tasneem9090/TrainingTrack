using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingTrack.data
{
    [Table("Books")]
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookDistribution> libookDistribution { get; set; }
    }
}
