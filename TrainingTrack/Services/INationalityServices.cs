using TrainingTrack.Models;

namespace TrainingTrack.Services
{
    public interface INationalityServices
    {
        void Delete(int id);
        NationalityModel Find(int id);
        void Insert(NationalityModel nationalityModel);
        List<NationalityModel> LaadAll();
        void Update(NationalityModel nationality);
    }
}