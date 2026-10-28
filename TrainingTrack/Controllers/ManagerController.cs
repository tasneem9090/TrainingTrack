using Microsoft.AspNetCore.Mvc;

namespace TrainingTrack.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult NewManager()
        {
            return View("NewManager");
        }
    }
}
