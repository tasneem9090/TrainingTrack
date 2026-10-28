using TrainingTrack.Models;

namespace TrainingTrack.Services
{
    public interface ITrainerServices
    {
        void Delete(int id);
        TrainerModel Find(int id);
        void Insert(TrainerModel trainerModel);
        List<TrainerModel> LaadAll();
        void Update(TrainerModel trainer);
        Task<int> GetEmployeeCountAsync();
    }
}