using TrainingTrack.Models;

namespace TrainingTrack.Services
{
    public interface IBookDistributionServices
    {
        void Delete(int id);
        BookDistributionModel Find(int id);
        void Insert(BookDistributionModel bookDistributionModel);
        List<BookDistributionModel> LaadAll();
        int GettotalCopies();
        void Update(BookDistributionModel bookDistributionModel);
    }
}