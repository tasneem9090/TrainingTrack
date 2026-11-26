using Microsoft.AspNetCore.Mvc;

namespace TrainingTrack.Controllers
{
    //public class ManagerController : Controller
    //{
    //    public IActionResult NewManager()
    //    {
    //        return View("NewManager");
    //    }
    //}

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = "Admin,Manager")] // عدّل أسماء الأدوار حسب المسميات الموجودة في نظامك
    public class ManagerController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public ManagerController(
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        // شاشة المدير الحالية
        public IActionResult NewManager()
        {
            return View("NewManager");
        }

        // إعطاء مستخدم صلاحية كاملة / دور معين على النظام
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GrantFullSystemAccess(string email, string roleName = "Admin")
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                TempData["Error"] = "يرجى إدخال البريد الإلكتروني للمستخدم.";
                return RedirectToAction(nameof(NewManager));
            }

            var user = await _userManager.FindByEmailAsync(email.Trim());
            if (user == null)
            {
                TempData["Error"] = "لم يتم العثور على مستخدم بهذا البريد الإلكتروني.";
                return RedirectToAction(nameof(NewManager));
            }

            // إنشاء الدور تلقائياً إذا لم يكن موجوداً في قاعدة البيانات
            if (!await _roleManager.RoleExistsAsync(roleName))
            {
                await _roleManager.CreateAsync(new IdentityRole(roleName));
            }

            // إسناد الدور للمستخدم إذا لم يكن مضافاً مسبقاً
            if (!await _userManager.IsInRoleAsync(user, roleName))
            {
                var result = await _userManager.AddToRoleAsync(user, roleName);
                if (!result.Succeeded)
                {
                    TempData["Error"] = "تعذر منح الصلاحية للمستخدم.";
                    return RedirectToAction(nameof(NewManager));
                }
            }

            TempData["Success"] = $"تم منح الصلاحية ({roleName}) للمستخدم {user.Email} بنجاح.";
            return RedirectToAction(nameof(NewManager));
        }
    }



}
