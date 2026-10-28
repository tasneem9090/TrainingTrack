using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TrainingTrack.data;
using TrainingTrack.Models;

namespace TrainingTrack.Services
{
    public class BookDistributionServices : IBookDistributionServices
    {
        IMapper mapper;
        TRContext context;
        public BookDistributionServices(IMapper _mapper, TRContext _context)
        {
            mapper = _mapper;
            context = _context;

        }

        public void Insert(BookDistributionModel bookDistributionModel)
        {
            BookDistribution bookDistribution = mapper.Map<BookDistribution>(bookDistributionModel);
            context.bookDistributions.Add(bookDistribution);
            context.SaveChanges();
        }
     
        public List<BookDistributionModel> LaadAll()
        {
            List<BookDistribution> albookDistributions = context.bookDistributions.Include("Book").Include("Hall").Include("Trainer").Include("Governorate").ToList();
        
            List<BookDistributionModel> bookDistributions = new List<BookDistributionModel>();
            bookDistributions = mapper.Map<List<BookDistributionModel>>(albookDistributions);
            return bookDistributions;

          
        }
        public int GettotalCopies()
        {
            return context.bookDistributions.Sum(x => x.NumberOfCopies);
        }
        public void Delete(int id)
        {
            BookDistribution bookDistribution = context.bookDistributions.Find(id);
            if (bookDistribution != null)
            {
                context.bookDistributions.Remove(bookDistribution);
                context.SaveChanges();
            }
        }
        public BookDistributionModel Find(int id)
        {
            BookDistribution bookDistribution = context.bookDistributions.Find(id);
            if (bookDistribution != null)
            {
                BookDistributionModel bookDistributionModel = mapper.Map<BookDistributionModel>(bookDistribution);
                return bookDistributionModel;
            }
            else
            {
                return null;
            }

        }
        public void Update(BookDistributionModel bookDistributionModel)
        {
            BookDistribution albookDistribution = context.bookDistributions.Find(bookDistributionModel.Id);
            if (albookDistribution != null)
            {
                // albookDistribution.TraineeId =bookDistributionModel.TraineeId;
                albookDistribution.Name = bookDistributionModel.Name;
                //albookDistribution.DistributionDate = bookDistributionModel.DistributionDate;
                //albookDistribution.Quantity = bookDistributionModel.Quantity;
                //albookDistribution.TotalBooks = bookDistributionModel.TotalBooks;
                context.SaveChanges();
            }
        }
    }
}





