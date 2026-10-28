using Microsoft.AspNetCore.Mvc;
using TrainingTrack.data;
using TrainingTrack.Models;
using TrainingTrack.Services;

namespace TrainingTrack.Controllers
{
    public class TrainingController : Controller
    {
        ITrainerServices trainerServices;
        ITrainingServices trainingServices;
        public TrainingController(ITrainerServices _trainerServices,
        ITrainingServices _trainingServices)
        {
            trainerServices=_trainerServices;
            trainingServices = _trainingServices;
        }
        public IActionResult NewTraining()
        {
            vmTraining vm = new vmTraining();
            vm.litrainerModels = new List<TrainerModel>();
            vm.litrainerModels = trainerServices.LaadAll();

            return View(vm);

        }



        public IActionResult Save(vmTraining vm)
        {
            ViewBag.IsEdit = true;
            ModelState.Remove("Id");
            //ModelState.Remove("HallId");
            ModelState.Remove("trainingModel.Trainer");
            if (ModelState.IsValid)
            {
                trainingServices.Insert(vm.trainingModel);
                int Id = vm.trainingModel.Id;
   
            }
            vm.litrainerModels = trainerServices.LaadAll();

            return View("NewTraining", vm);
        }
        public IActionResult TrainingList()
        {

            List<TrainingModel> trainings = trainingServices.LaadAll();
            return View(trainings);
        }
        public IActionResult Delete(int Id)
        {
            trainingServices.Delete(Id);
            List<TrainingModel> Training = trainingServices.LaadAll();
            return View("TrainingList", Training);
        }
        public IActionResult Edit(int Id)
        {
            ViewBag.IsEdit = true;
            vmTraining vm = new vmTraining();
            TrainingModel trainingss = trainingServices.LaFind(Id);
            List<TrainingModel> Trainings = trainingServices.LaadAll();

            vm.trainingModel = trainingss;
            vm.litrainerModels = trainerServices.LaadAll();
        
            return View("NewTraining",vm);
          
           
           
           
        }
        public IActionResult Updatee(TrainingModel trainingModel)
        {
            trainingServices.Update(trainingModel);
            ViewBag.IsEdit = true;
            return View("NewTraining");
        }
    }
}


