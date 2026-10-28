using Microsoft.AspNetCore.Identity;
using TrainingTrack.Models;

namespace TrainingTrack.Services
{
    public class AccountServices : IAccountServices
    {
        UserManager<ApplicationUser> userManager;
        SignInManager<ApplicationUser> signInManager;
        public AccountServices(UserManager<ApplicationUser> _userManager,SignInManager<ApplicationUser> _signInManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
        }
        public async Task<IdentityResult> CreateAccount(SignUp user)
        {
            ApplicationUser newUser = new ApplicationUser();
            newUser.UserName = user.Email;
            newUser.Email = user.Email;

            //newUser.PasswordHash = user.Password;

            var CreationResult = await userManager.CreateAsync(newUser,user.Password);
            return CreationResult;
        }
        public async Task <SignInResult> SignIn(SignInModel signInModel)
        {

         var result=await signInManager.PasswordSignInAsync(signInModel.Username, signInModel.Password,false,false);
            return result;
        }
    }
}
