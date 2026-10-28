using AutoMapper;
using TrainingTrack.Models;

namespace TrainingTrack.data
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookModel>().ReverseMap();
            CreateMap<BookDistribution, BookDistributionModel>().ReverseMap();
            CreateMap<DailyReport, DailyReportModel>().ReverseMap();
            CreateMap<Governorate, GovernorateModel>().ReverseMap();
            CreateMap<Nationality, BookDistributionModel>().ReverseMap();
            CreateMap<Hall, HallModel>().ReverseMap();        
            CreateMap<Nationality, NationalityModel>().ReverseMap();
            CreateMap<Trainee, TraineeModel>().ReverseMap();
            CreateMap<Trainer, TrainerModel>().ReverseMap();
            CreateMap<Training, TrainingModel>().ReverseMap();
        }
    }
}
