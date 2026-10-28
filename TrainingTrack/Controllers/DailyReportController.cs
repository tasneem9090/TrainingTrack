using Microsoft.AspNetCore.Mvc;
using TrainingTrack.data;
using TrainingTrack.Models;
using TrainingTrack.Services;

namespace TrainingTrack.Controllers
{
    public class DailyReportController : Controller
    {
        ITrainerServices trainerServices;
        IDailyReportServices dailyReportServices;
        //IFileService fileService;
        public DailyReportController(IDailyReportServices _dailyReportServices,
            ITrainerServices _trainerServices)
        {
            trainerServices = _trainerServices;
            dailyReportServices = _dailyReportServices;
          
        }
        public IActionResult NewDailyReport()
        {
          
            vmDailyReport vm = new vmDailyReport();
            vm.litrainerModel = new List<TrainerModel>();
            vm.litrainerModel = trainerServices.LaadAll();
            return View(vm);
        }

        public IActionResult Save(vmDailyReport vm)
        {

            ModelState.Remove("Id");
            ModelState.Remove("dailyReportModel.image");
            ModelState.Remove("dailyReportModel.imgeName");
            ModelState.Remove("dailyReport.Trainer");
            if (ModelState.IsValid)
            {
                if (vm.dailyReport.image != null)
                {
                    //string imageName = Guid.NewGuid().ToString() + "." + vm.dailyReportModel.image.FileName.Split('.')[1];
                    string uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "image");
                    if (!Directory.Exists(uploadFolder))
                    {
                        Directory.CreateDirectory(uploadFolder);
                    }
                    string fileName = Guid.NewGuid().ToString() + "_" + vm.dailyReport.image.FileName;
                    string filePath = Path.Combine(uploadFolder, fileName);
                    vm.dailyReport.image.CopyTo(new FileStream(filePath, FileMode.Create));
                    vm.dailyReport.imgeName = fileName;
                }

                dailyReportServices.Insert(vm.dailyReport);
                //int Id = vm.dailyReport.Id;


            }

            vm.litrainerModel = trainerServices.LaadAll();
            return View("NewDailyReport", vm);


        }

        public IActionResult DailyReportList()
        {
            List<DailyReportModel> dailyReportss = dailyReportServices.LaadAll();
            return View(dailyReportss);
        }

        public IActionResult Delete(int Id)
        {
            dailyReportServices.Delete(Id);
            List<DailyReportModel> reportModels = dailyReportServices.LaadAll();
            return View("DailyReportList", reportModels);
        }
        public IActionResult Edit(int Id)
        {
            ViewBag.IsEdit = true;
            vmDailyReport vm = new vmDailyReport();
            DailyReportModel dailyReportModel = dailyReportServices.LaFind(Id);
            List<DailyReportModel> dailyReportss = dailyReportServices.LaadAll();
            vm.dailyReport = dailyReportModel;
            vm.litrainerModel = trainerServices.LaadAll();
            return View("NewDailyReport", vm);
        }
        public IActionResult Updatee(DailyReportModel daily)
        {
            dailyReportServices.Update(daily);
            ViewBag.IsEdit = true;
            return View("NewDailyReport");
        }

        public IActionResult Updateimge(vmDailyReport vm)
        {
            ModelState.Remove("Id");
            ModelState.Remove("dailyReportModel.FileName");
            ViewBag.IsEdit = true;
            if (ModelState.IsValid)
            {
                if (vm.dailyReport.image != null)
                {
                    string uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");
                    if (!string.IsNullOrEmpty(vm.dailyReport.imgeName))
                    {

                        string aldailyReport = Path.Combine(uploadFolder, vm.dailyReport.imgeName);
                        if (System.IO.File.Exists(aldailyReport))
                        {
                            System.IO.File.Delete(aldailyReport);
                        }
                    }
                    //string imageName = Guid.NewGuid().ToString() + "." + vm.dailyReportModel.image.FileName.Split('.')[1];
                    if (!Directory.Exists(uploadFolder))
                    {
                        Directory.CreateDirectory(uploadFolder);
                    }
                    string fileName = Guid.NewGuid().ToString() + "_" + vm.dailyReport.image.FileName;
                    string filePath = Path.Combine(uploadFolder, fileName);
                    vm.dailyReport.image.CopyTo(new FileStream(filePath, FileMode.Create));
                    vm.dailyReport.imgeName = fileName;
                }



                dailyReportServices.Update(vm.dailyReport);

            }
            vm.litrainerModel = trainerServices.LaadAll();
            return View("NewDailyReport", vm);
        }


    }
}

  