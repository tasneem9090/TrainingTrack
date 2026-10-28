using AutoMapper;
using TrainingTrack.data;
using TrainingTrack.Models;

namespace TrainingTrack.Services
{
    public class BookServices : IBookServices
    {
        IMapper mapper;
        TRContext context;
        public BookServices(IMapper _mapper, TRContext _context)
        {

            mapper = _mapper;
            context = _context;
        }

        public void Insert(BookModel bookModel)
        {
            Book newBook = mapper.Map<Book>(bookModel);
            context.books.Add(newBook);
            context.SaveChanges();
        }
        public List<BookModel> LaadAll()
        {
            List<Book> albooks = context.books.ToList();
            List<BookModel> bookModels = new List<BookModel>();
            bookModels = mapper.Map<List<BookModel>>(albooks);
            return bookModels;
        }

        public void Delete(int id)
        {
            Book book = context.books.Find(id);
            if (book != null)
            {
                context.books.Remove(book);
                context.SaveChanges();
            }
        }
        public BookModel Find(int id)
        {
            Book book = context.books.Find(id);
            if (book != null)
            {
                BookModel bookModel = mapper.Map<BookModel>(book);
                return bookModel;
            }
            else
            {
                return null;
            }

        }
        public void Update(BookModel bookModel)
        {
            Book albook = context.books.Find(bookModel.Id);
            if (albook != null)
            {
                albook.Name = bookModel.Name;

                context.SaveChanges();
            }
        }
    }
}
