using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TrainingTrack.data;
using TrainingTrack.Models;
using static TrainingTrack.Services.DailyReportServices;

namespace TrainingTrack.Services
{
    public class DailyReportServices : IDailyReportServices
    {
        IMapper mapper;
        TRContext context;
        public DailyReportServices(IMapper _mapper, TRContext _context)
        {

            mapper = _mapper;
            context = _context;
        }
        public void Insert(DailyReportModel dailyReportModel)
        {
            DailyReport newdailyReport = mapper.Map<DailyReport>(dailyReportModel);
            newdailyReport.ContentType = dailyReportModel.ContentType;
            context.dailyReports.Add(newdailyReport);
            context.SaveChanges();
          
        }
        public List<DailyReportModel> LaadAll()
        {
            List<DailyReport> aldailyReports= context.dailyReports.Include("Trainer").ToList();
            List<DailyReportModel> dailyReportss = new List<DailyReportModel>();
            dailyReportss = mapper.Map<List<DailyReportModel>>(aldailyReports);
            return dailyReportss;

        }
      
        public void Delete(int id)
        {
            DailyReport daily = context.dailyReports.Find(id);
            if (daily != null)
            {
                context.dailyReports.Remove(daily);
                context.SaveChanges();
            }
        }
        public DailyReportModel LaFind(int Id)
        {
            DailyReport daily = context.dailyReports.Find(Id);
            if (daily != null)
            {
                DailyReportModel dailyReport = mapper.Map<DailyReportModel>(daily);
                return dailyReport;
            }
            else
            {
                return null;
            }

        }
        public void Update(DailyReportModel dailyReport)
        {
            DailyReport aldailyReport = context.dailyReports.Find(dailyReport.Id);
            if (aldailyReport != null)
            {
                aldailyReport.Name = dailyReport.Name;
                aldailyReport.TrainerId = dailyReport.TrainerId;
                aldailyReport.Date = dailyReport.Date;
                aldailyReport.Notes = dailyReport.Notes;
                aldailyReport.imgeName = dailyReport.imgeName;
                context.SaveChanges();
            }

        }
          
    }

}

    

