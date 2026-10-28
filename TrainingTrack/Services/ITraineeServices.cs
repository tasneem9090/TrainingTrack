using TrainingTrack.Models;

namespace TrainingTrack.Services
{
    public interface ITraineeServices
    {
        void Delete(int id);
        int GetFemaleCount();
        int GetMaleCount();
        void Insert(TraineeModel traineeModel);
        List<TraineeModel> LaadAll();
        TraineeModel LaFind(int Id);
        void Update(TraineeModel traineeModel);
    }
}