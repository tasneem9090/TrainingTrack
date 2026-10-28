using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrainingTrack.Models;
using TrainingTrack.Services;

namespace TrainingTrack.Controllers
{
    //[Authorize]
    public class TraineeController : Controller
    {
        INationalityServices nationalityServices;
        ITraineeServices traineeService;
        public TraineeController(ITraineeServices _traineeServices,
            INationalityServices _nationalityServices)
        {
            traineeService = _traineeServices;
            nationalityServices = _nationalityServices;
        }
        
        public IActionResult NewTrainee()
        {
       
            ViewBag.IsEdit = false;
            vmTrainee vm = new vmTrainee();
            vm.linationalityModel = new List<NationalityModel>();
            vm.linationalityModel = nationalityServices.LaadAll();
            return View(vm);
        }
        public IActionResult Save(vmTrainee vm)
        {
            ViewBag.IsEdit = true;
            ModelState.Remove("Id");
            ModelState.Remove("traineeModel.Nationality");
          
            if (ModelState.IsValid)
            {
                traineeService.Insert(vm.traineeModel);
                int Id = vm.traineeModel.Id;

            }
            vm.linationalityModel = nationalityServices.LaadAll();
            return View("NewTrainee", vm);
        }

        public async Task<IActionResult> TraineeList()
        {
            int femaleCount = traineeService.GetFemaleCount();
            int maleCount = traineeService.GetMaleCount();
            ViewBag.MaleCount = maleCount;
            ViewBag.FemaleCount = femaleCount;

            List<TraineeModel> trainees = traineeService.LaadAll();
            return View(trainees);
        }

        public IActionResult Delete(int Id)
        {
            traineeService.Delete(Id);
            List<TraineeModel> trainees = traineeService.LaadAll();
            return View("TraineeList", trainees);
        }
        public IActionResult Edit(int Id)
        {
            ViewBag.IsEdit = true;
            vmTrainee vm = new vmTrainee();
            TraineeModel trainee= traineeService.LaFind(Id);
            List<TraineeModel> trainees = traineeService.LaadAll();
            vm.traineeModel=trainee;
            vm.linationalityModel = nationalityServices.LaadAll();
            return View("NewTrainee", vm);
           
           
        }
        public IActionResult Updatee(TraineeModel traineeModel)
        {
            ViewBag.IsEdit = true;
            traineeService.Update(traineeModel);
            
            return View("NewTrainee");
         }

    }
}

    