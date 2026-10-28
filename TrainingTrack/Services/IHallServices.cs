using TrainingTrack.Models;

namespace TrainingTrack.Services
{
    public interface IHallServices
    {
        void Insert(HallModel hallModel);
        List<HallModel> LaadAll();
    }
}