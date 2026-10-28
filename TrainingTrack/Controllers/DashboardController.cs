using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TrainingTrack.Services;

namespace TrainingTrack.Controllers
{
    public class DashboardController : Controller
    {
        ITrainerServices trainerServices;
        public DashboardController(ITrainerServices _trainerServices)
        {
            trainerServices = _trainerServices;
        }
        public async Task<IActionResult> NewDashboard()
        {
            ViewBag.TrainerCount = await trainerServices.GetEmployeeCountAsync();

            return View();
        }
      
    }
}
