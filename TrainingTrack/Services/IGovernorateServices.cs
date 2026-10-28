using TrainingTrack.Models;

namespace TrainingTrack.Services
{
    public interface IGovernorateServices
    {
        void Delete(int id);
        GovernorateModel Find(int id);
        void Insert(GovernorateModel governorateModel);
        List<GovernorateModel> LaadAll();
        void Update(GovernorateModel governorate);
    }
}