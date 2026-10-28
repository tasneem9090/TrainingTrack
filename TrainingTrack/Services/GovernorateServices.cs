using AutoMapper;
using TrainingTrack.data;
using TrainingTrack.Models;

namespace TrainingTrack.Services
{
    public class GovernorateServices : IGovernorateServices
    {
        IMapper mapper;
        TRContext context;
        public GovernorateServices(IMapper _mapper, TRContext _context)
        {
            mapper = _mapper;
            context = _context;

        }

        public void Insert(GovernorateModel governorateModel)
        {
            Governorate Newgovernorate = mapper.Map<Governorate>(governorateModel);

            context.governorates.Add(Newgovernorate);
            context.SaveChanges();

        }
        public List<GovernorateModel> LaadAll()
        {
            List<Governorate> algovernorates = context.governorates.ToList();
            List<GovernorateModel> governoratess = new List<GovernorateModel>();
            governoratess = mapper.Map<List<GovernorateModel>>(algovernorates);
            return governoratess;
        }
        public void Delete(int id)
        {
            Governorate governorate = context.governorates.Find(id);
            if (governorate != null)
            {
                context.governorates.Remove(governorate);
                context.SaveChanges();
            }
        }
        public GovernorateModel Find(int id)
        {
            Governorate governorate = context.governorates.Find(id);
            if (governorate != null)
            {
                GovernorateModel governorateModel = mapper.Map<GovernorateModel>(governorate);
                return governorateModel;
            }
            else
            {
                return null;
            }

        }
        public void Update(GovernorateModel governorate)
        {
            Governorate algovernorate = context.governorates.Find(governorate.Id);
            if (algovernorate != null)
            {
                algovernorate.Name = governorate.Name;

                context.SaveChanges();
            }
        }
    }
}

    
