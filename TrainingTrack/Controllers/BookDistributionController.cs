using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrainingTrack.Models;
using TrainingTrack.Services;

namespace TrainingTrack.Controllers
{
    //[Authorize]
    public class BookDistributionController : Controller
    {


            IBookDistributionServices bookDistributionServices;
            ITrainerServices trainerServices;
            IBookServices bookServices;
            IGovernorateServices governorateServices;
            IHallServices hallServices;
            public BookDistributionController(IBookDistributionServices _bookDistributionServices,
                ITrainerServices _trainerServices, IBookServices _bookServices,
                IGovernorateServices _governorateServices, IHallServices _hallServices)
            {
                bookDistributionServices = _bookDistributionServices;
                trainerServices = _trainerServices;
                bookServices = _bookServices;
                governorateServices = _governorateServices;
                hallServices = _hallServices;
            }
            
           public IActionResult NewBookDistribution()
            {

                ViewBag.IsEdit = false;
                vmBookDistribution vm = new vmBookDistribution();
                vm.ligovernorateModels = new List<GovernorateModel>();
                vm.ligovernorateModels = governorateServices.LaadAll();
                vm.litrainerModels = new List<TrainerModel>();
                vm.litrainerModels = trainerServices.LaadAll();
                vm.libookModels = new List<BookModel>();
                vm.libookModels = bookServices.LaadAll();
                vm.lihallModels = new List<HallModel>();
                vm.lihallModels = hallServices.LaadAll();
                return View(vm);

            }

            public IActionResult Save(vmBookDistribution vm)
            {
                ViewBag.IsEdit = true;

             ModelState.Remove("Id");
             ModelState.Remove("bookDistributionModel.Book");
             ModelState.Remove("bookDistributionModel.Hall");
             ModelState.Remove("bookDistributionModel.Trainer");
             ModelState.Remove("bookDistributionModel.Governorate");

            if (ModelState.IsValid)
                {
                    bookDistributionServices.Insert(vm.bookDistributionModel);
                    int Id = vm.bookDistributionModel.Id;

                }

                vm.ligovernorateModels = governorateServices.LaadAll();
                vm.libookModels = bookServices.LaadAll();
                vm.lihallModels = hallServices.LaadAll();
                vm.litrainerModels = trainerServices.LaadAll();


                return View("NewBookDistribution", vm);
            }


            public IActionResult BookDistributionList()
            {

                ViewBag.TotalCopies = bookDistributionServices.GettotalCopies();
                List<BookDistributionModel> bookDistributions = bookDistributionServices.LaadAll();
                return View(bookDistributions);
            }

            public IActionResult Delete(int Id)
            {
                bookDistributionServices.Delete(Id);
                List<BookDistributionModel> bookDistributions = bookDistributionServices.LaadAll();
                return View("BookDistributionList", bookDistributions);
            }
            public IActionResult Edit(int Id)
            {
                ViewBag.IsEdit = true;
            vmBookDistribution vm = new vmBookDistribution();
              BookDistributionModel bookDistributionModel = bookDistributionServices.Find(Id);
            List<BookDistributionModel> bookDistributionss = bookDistributionServices.LaadAll();
            vm.bookDistributionModel = bookDistributionModel;
            vm.litrainerModels = trainerServices.LaadAll();
            vm.libookModels = bookServices.LaadAll();
            vm.lihallModels = hallServices.LaadAll();
            vm.ligovernorateModels = governorateServices.LaadAll();
            return View("NewBookDistribution", vm);
    
      
        }
            public IActionResult Updatee(BookDistributionModel book)
            {
                bookDistributionServices.Update(book);
                ViewBag.IsEdit = true;
                return View("NewBookDistribution");
            }

        }
    }


