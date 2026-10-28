using Microsoft.AspNetCore.Mvc;
using TrainingTrack.Models;
using TrainingTrack.Services;

namespace TrainingTrack.Controllers
{

    public class NationalityController : Controller
    {
        INationalityServices nationalityServices;
        public NationalityController(INationalityServices _nationalityServices)
        {
            nationalityServices = _nationalityServices;

        }
        public IActionResult NewNationality()
        {
            return View("NewNationality");
        }
      
        public IActionResult Save(NationalityModel nationalityModel)
        {

            nationalityServices.Insert(nationalityModel);

            return View("NewNationality", nationalityModel);
        }
        public IActionResult NationalityList()
        {
            List<NationalityModel> nationalityModels = nationalityServices.LaadAll();
            return View(nationalityModels);

        }
        public IActionResult Delete(int Id)
        {
            nationalityServices.Delete(Id);
            List<NationalityModel> nationalityModels = nationalityServices.LaadAll();
            return View("NationalityList", nationalityModels);
        }

        public IActionResult Edit(int Id)
        {
            ViewBag.IsEdit = true;
            NationalityModel nationalitie = nationalityServices.Find(Id);
            return View("NewNationality", nationalitie);
        }
        public IActionResult Updatedepart(NationalityModel nationalityModel)
        {
            nationalityServices.Update(nationalityModel);
            ViewBag.IsEdit = true;
            return View("NewNationality");
        }
    }

}

    

