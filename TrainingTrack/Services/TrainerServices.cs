using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using TrainingTrack.data;
using TrainingTrack.Models;

namespace TrainingTrack.Services
{
    public class TrainerServices : ITrainerServices
    {
        IMapper mapper;
        TRContext context;
        public TrainerServices(IMapper _mapper, TRContext _context)
        {
            mapper = _mapper;
            context = _context;
        }
        public void Insert(TrainerModel trainerModel)
        {
            Trainer Newtrainer = mapper.Map<Trainer>(trainerModel);

            context.trainers.Add(Newtrainer);
            context.SaveChanges();
        }
        public List<TrainerModel> LaadAll()
        {
            List<Trainer> allTrainer = context.trainers.ToList();
            List<TrainerModel> trainers = new List<TrainerModel>();
            trainers = mapper.Map<List<TrainerModel>>(allTrainer);
            return trainers;
        }
        public void Delete(int id)
        {
            Trainer trainer = context.trainers.Find(id);
            if (trainer != null)
            {
                context.trainers.Remove(trainer);
                context.SaveChanges();
            }
        }
        public TrainerModel Find(int id)
        {
            Trainer trainer = context.trainers.Find(id);
            if (trainer != null)
            {
                TrainerModel trainerModel = mapper.Map<TrainerModel>(trainer);
                return trainerModel;
            }
            else
            {
                return null;
            }

        }
        public void Update(TrainerModel trainer)
        {
            Trainer altrainer = context.trainers.Find(trainer.Id);
            if (altrainer != null)
            {
                altrainer.FirstName = trainer.FirstName;
                altrainer.LastName = trainer.LastName;
                altrainer.FirstName = trainer.FirstName;
                altrainer.DateofBirth = trainer.DateofBirth;
                altrainer.Phone = trainer.Phone;
                altrainer.Email = trainer.Email;
                context.SaveChanges();
            }
        }
        public async Task<int> GetEmployeeCountAsync()
        {
            return await context.trainers.CountAsync();
        }
    }
}

    

