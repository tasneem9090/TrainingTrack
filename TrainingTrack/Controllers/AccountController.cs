using Microsoft.AspNetCore.Mvc;
using TrainingTrack.Models;
using TrainingTrack.Services;

namespace TrainingTrack.Controllers
{
    public class AccountController : Controller
    {
        IAccountServices accountServices;
        public AccountController(IAccountServices _accountServices)
        {
            accountServices = _accountServices;
        }
        public IActionResult SignUp()
        {
            return View("SignUp");
        }
        public async Task <IActionResult> CreateAccount(SignUp signUp)
        {
           var result= await accountServices.CreateAccount(signUp);

            return View("SignUp");
        }
        public IActionResult SignIn()
        {
            ViewData["InValid"] = false;
            return View("SignIn");

        }
        public async Task<IActionResult >Login(SignInModel Model)
        {
           var result=await accountServices.SignIn(Model);
            if (result.Succeeded)
            {
                return RedirectToAction("NewDashboard", "Dashboard");
            }
            else {
                ViewData["InValid"] = true;
                return View("SignIn");
            }

        }
    }
}
