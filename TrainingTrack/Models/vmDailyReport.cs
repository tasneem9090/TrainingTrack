namespace TrainingTrack.Models
{
    public class vmDailyReport
    {
        public DailyReportModel? dailyReport { get; set; }
        public List<TrainerModel> litrainerModel { get; set; } = new List<TrainerModel>();
    }
}

