using Microsoft.AspNetCore.Mvc;
using TrainingTrack.Models;
using TrainingTrack.Services;

namespace TrainingTrack.Controllers
{
    public class GovernorateController : Controller
    {
        IGovernorateServices governorateServices;
        public GovernorateController(IGovernorateServices _governorateServices)
        {
            governorateServices = _governorateServices;


        }
        public IActionResult NewGovernorate()
        {
            return View("NewGovernorate");
        }

      
        public IActionResult Save(GovernorateModel governorateModel)
        {
            governorateServices.Insert(governorateModel);
            return View("NewGovernorate", governorateModel);
        }
        public IActionResult GovernorateList()
        {
            List<GovernorateModel> governorates = governorateServices.LaadAll();
            return View(governorates);
        }
        public IActionResult Delete(int Id)
        {
            governorateServices.Delete(Id);
            List<GovernorateModel> governorateModels = governorateServices.LaadAll();
            return View("trainerList", governorateModels);
        }

        public IActionResult Edit(int Id)
        {
            ViewBag.IsEdit = true;
            GovernorateModel governorate = governorateServices.Find(Id);
            return View("NewGovernorate", governorate);
        }
        public IActionResult Updatedepart(GovernorateModel governorateModel)
        {
            governorateServices.Update(governorateModel);
            ViewBag.IsEdit = true;
            return View("NewGovernorate");

        }
    }
}
