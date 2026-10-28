using TrainingTrack.Models;

namespace TrainingTrack.Services
{
    public interface ITrainingServices
    {
        void Delete(int id);
        void Insert(TrainingModel training);
        List<TrainingModel> LaadAll();
        TrainingModel LaFind(int Id);
        void Update(TrainingModel trainingModel);
    }
}