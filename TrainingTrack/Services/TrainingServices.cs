using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TrainingTrack.data;
using TrainingTrack.Models;

namespace TrainingTrack.Services
{
    public class TrainingServices : ITrainingServices
    {
        IMapper mapper;
        TRContext context;
        public TrainingServices(IMapper _mapper, TRContext _context)
        {
            mapper = _mapper;
            context = _context;
        }
        public void Insert(TrainingModel training)
        {
            Training newtraining = mapper.Map<Training>(training);
            context.trainings.Add(newtraining);
            context.SaveChanges();
        }
        public List<TrainingModel> LaadAll()
        {
            List<Training> alTraining = context.trainings.Include("Trainer").ToList();
            List<TrainingModel> trainingss = new List<TrainingModel>();
            trainingss = mapper.Map<List<TrainingModel>>(alTraining);

            return trainingss;
        
      
        }
        public void Delete(int id)
        {
            Training training = context.trainings.Find(id);
            if (training != null)
            {
                context.trainings.Remove(training);
                context.SaveChanges();
            }
        }
        public TrainingModel LaFind(int Id)
        {
            Training training = context.trainings.Find(Id);
            if (training != null)
            {
                TrainingModel trainingModel = mapper.Map<TrainingModel>(training);
                return trainingModel;
            }
            else
            {
                return null;
            }

        }
        public void Update(TrainingModel trainingModel)
        {
            Training altraining = context.trainings.Find(trainingModel.Id);
            if (altraining != null)
            {
                altraining.Name = trainingModel.Name;
                altraining.StartDate = trainingModel.StartDate;
                altraining.EndDate = trainingModel.EndDate;

                altraining.TrainerId = trainingModel.TrainerId;
                context.SaveChanges();
            }
        }
    }
}

 
