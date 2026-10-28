using Microsoft.AspNetCore.Mvc;

namespace TrainingTrack.Controllers
{
    public class InformationController : Controller
    {
        public IActionResult NewInformation()
        {
            return View("NewInformation");
        }
    }
}
