using TrainingTrack.Models;

namespace TrainingTrack.Services
{
    public interface IDailyReportServices
    {
        void Delete(int id);
       void Insert(DailyReportModel dailyReportModel);
        List<DailyReportModel> LaadAll();
        DailyReportModel LaFind(int Id);
        void Update(DailyReportModel dailyReport);
    }
}