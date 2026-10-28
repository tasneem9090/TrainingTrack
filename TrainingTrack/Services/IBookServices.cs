using TrainingTrack.Models;

namespace TrainingTrack.Services
{
    public interface IBookServices
    {
        void Delete(int id);
        BookModel Find(int id);
        void Insert(BookModel bookModel);
        List<BookModel> LaadAll();
        void Update(BookModel bookModel);
    }
}