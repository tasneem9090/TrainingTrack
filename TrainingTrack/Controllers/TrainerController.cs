using Microsoft.AspNetCore.Mvc;
using TrainingTrack.Models;
using TrainingTrack.Services;

namespace TrainingTrack.Controllers
{
    public class TrainerController : Controller
    {
        ITrainerServices trainerServices;
        public TrainerController(ITrainerServices _trainerServices)
        {
            trainerServices = _trainerServices;
        }

       
        public IActionResult NewTrainer()
        {
            return View("NewTrainer");
        }
        public IActionResult Save(TrainerModel trainerModel)
        {

            trainerServices.Insert(trainerModel);
            return View("NewTrainer", trainerModel);
        }
        public IActionResult trainerList()
        {
            List<TrainerModel> trainers = trainerServices.LaadAll();
            return View(trainers);

        }
        public IActionResult Delete(int Id)
        {
            trainerServices.Delete(Id);
            List<TrainerModel> trainerModels = trainerServices.LaadAll();
            return View("trainerList", trainerModels);
        }

        public IActionResult Edit(int Id)
        {
            ViewBag.IsEdit = true;
            TrainerModel trainerss = trainerServices.Find(Id);
            return View("NewTrainer", trainerss);
        }
        public IActionResult Updatedepart(TrainerModel trainerModel)
        {
            trainerServices.Update(trainerModel);
            ViewBag.IsEdit = true;
            return View("NewTrainer");
        }
      
    }
}
