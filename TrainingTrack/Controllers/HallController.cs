using Microsoft.AspNetCore.Mvc;
using TrainingTrack.Models;
using TrainingTrack.Services;

namespace TrainingTrack.Controllers
{
    public class HallController : Controller
    {
        IHallServices hallServices;
        public HallController(IHallServices _hallServices)
        {
            hallServices = _hallServices;
        }
        public IActionResult NewHall()
        {
            return View("NewHall");
        }
        public IActionResult Save(HallModel hallModel)
        {

            hallServices.Insert(hallModel);

            return View("NewHall", hallModel);
        }
        public IActionResult HallList()
        {
            List<HallModel> hallModels = hallServices.LaadAll();
            return View(hallModels);

        }

   
    }
}



