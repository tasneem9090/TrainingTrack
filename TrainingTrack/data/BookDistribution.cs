using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingTrack.data
{
    [Table("BookDistributions")]
    public class BookDistribution
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey(nameof(BookId))]
        public Book Book { get; set; }
        public int? BookId { get; set; }
        [ForeignKey(nameof(HallId))]
        public int? HallId { get; set; }
        public Hall Hall { get; set; }
        [ForeignKey(nameof(GovernorateId))]
        public int? GovernorateId { get; set; }
        public Governorate Governorate { get; set; }
        [ForeignKey(nameof(TrainerId))]
        public int? TrainerId { get; set; }
        public Trainer Trainer { get; set; }
        public int NumberOfCopies { get; set; }
    
        public DateTime DistributionDate { get; set; }


    }
}
