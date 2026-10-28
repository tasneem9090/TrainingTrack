using Microsoft.AspNetCore.Identity;
using TrainingTrack.Models;

namespace TrainingTrack.Services
{
    public interface IAccountServices
    {
        Task<IdentityResult> CreateAccount(SignUp user);
        Task<SignInResult> SignIn(SignInModel signInModel);
    }
}