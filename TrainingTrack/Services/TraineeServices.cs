using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TrainingTrack.data;
using TrainingTrack.Models;

namespace TrainingTrack.Services
{
    public class TraineeServices : ITraineeServices
    {
        IMapper mapper;
        TRContext context;
        public TraineeServices(IMapper _mapper, TRContext _context)
        {


            mapper = _mapper;
            context = _context;
        }
        public void Insert(TraineeModel traineeModel)
        {
            Trainee trainee = mapper.Map<Trainee>(traineeModel);
            context.trainees.Add(trainee);
            context.SaveChanges();
        }
        
        public int GetFemaleCount()
        {
            return context.trainees.Count(G => G.Gender == "أنثى");
        }
        public int GetMaleCount()
        {
            return context.trainees.Count(G => G.Gender == "ذكر");
        }
        public List<TraineeModel> LaadAll()
        {
            List<Trainee> altrainee = context.trainees.Include("Nationality").ToList();
            
            List<TraineeModel> trainees = new List<TraineeModel>();
            trainees = mapper.Map<List<TraineeModel>>(altrainee);
            return trainees;
        }
        public void Delete(int Id)
        {
            Trainee trainee = context.trainees.Find(Id);
            if (trainee != null)
            {
                context.trainees.Remove(trainee);
                context.SaveChanges();
            }
        }
        public TraineeModel LaFind(int Id)
        {
            Trainee trainee = context.trainees.Find(Id);
            if (trainee != null)
            {
                TraineeModel traineeModel = mapper.Map<TraineeModel>(trainee);
                return traineeModel;
            }
            else
            {
                return null;
            }


        }

        
        public void Update(TraineeModel traineeModel)
        {

            Trainee altrainee = context.trainees.Find(traineeModel.Id);
            if (altrainee != null)
            {
                altrainee.Name = traineeModel.Name;
                altrainee.Phone = traineeModel.Phone;
                altrainee.Gender = traineeModel.Gender;
                altrainee.NationalityId = traineeModel.NationalityId;

                context.SaveChanges();
            }
        }





    }
}

    
