using AutoMapper;
using TrainingTrack.data;
using TrainingTrack.Models;

namespace TrainingTrack.Services
{
    public class HallServices : IHallServices
    {
        IMapper mapper;
        TRContext context;
        public HallServices(IMapper _mapper, TRContext _context)
        {
            mapper = _mapper;
            context = _context;
        }
        public void Insert(HallModel hallModel)
        {
            Hall newhall = mapper.Map<Hall>(hallModel);

            context.halls.Add(newhall);
            context.SaveChanges();

        }
        public List<HallModel> LaadAll()
        {
            List<Hall> allHall = context.halls.ToList();
            List<HallModel> hallss = new List<HallModel>();
            hallss = mapper.Map<List<HallModel>>(allHall);
            return hallss;
        }
    }
}


