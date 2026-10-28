using AutoMapper;
using TrainingTrack.data;
using TrainingTrack.Models;

namespace TrainingTrack.Services
{
    public class NationalityServices : INationalityServices
    {
        IMapper mapper;
        TRContext context;
        public NationalityServices(IMapper _mapper, TRContext _context)
        {
            mapper = _mapper;
            context = _context;
        }

        public void Insert(NationalityModel nationalityModel)
        {
            Nationality newnationality = mapper.Map<Nationality>(nationalityModel);

            context.nationalities.Add(newnationality);
            context.SaveChanges();
        }
        public List<NationalityModel> LaadAll()
        {
            List<Nationality> alnationalities = context.nationalities.ToList();
            List<NationalityModel> nationalitiess = new List<NationalityModel>();
            nationalitiess = mapper.Map<List<NationalityModel>>(alnationalities);
            return nationalitiess;
        }
        public void Delete(int id)
        {
            Nationality nationality = context.nationalities.Find(id);
            if (nationality != null)
            {
                context.nationalities.Remove(nationality);
                context.SaveChanges();
            }
        }
        public NationalityModel Find(int id)
        {
            Nationality nationality = context.nationalities.Find(id);
            if (nationality != null)
            {
                NationalityModel nationalityModel = mapper.Map<NationalityModel>(nationality);
                return nationalityModel;
            }
            else
            {
                return null;
            }

        }
        public void Update(NationalityModel nationality)
        {
            Nationality alnationality = context.nationalities.Find(nationality.Id);
            if (alnationality != null)
            {
                alnationality.Name = nationality.Name;

                context.SaveChanges();
            }
        }
    }
}

