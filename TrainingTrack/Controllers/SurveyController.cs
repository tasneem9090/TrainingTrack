using Microsoft.AspNetCore.Mvc;

namespace TrainingTrack.Controllers
{
    public class SurveyController : Controller
    {
        public IActionResult NewSurvey()
        {
            return View("NewSurvey");
        }
    }
}
