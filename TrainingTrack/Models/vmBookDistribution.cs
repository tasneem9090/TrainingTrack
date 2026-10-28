namespace TrainingTrack.Models
{
    public class vmBookDistribution
    {
        public BookDistributionModel? bookDistributionModel { get; set; }
        public List<TrainerModel> litrainerModels { get; set; } = new List<TrainerModel>();

        public List<BookModel> libookModels { get; set; } = new List<BookModel>();
        public List<HallModel> lihallModels { get; set; } = new List<HallModel>();

        public List<GovernorateModel> ligovernorateModels { get; set; } = new List<GovernorateModel>();
    }
}

