using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RecipeSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeSystem.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userMgr, SignInManager<IdentityUser> signInMgr)
        {
            userManager = userMgr;
            signInManager = signInMgr;
        }

        [AllowAnonymous]
        public ViewResult Login(string returnUrl)
        {
            return View(new Login {
                ReturnUrl = returnUrl
            });
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken] // Someone is try to hack the system, we add this extra layer for security
        public async Task<IActionResult> Login(Login login)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await userManager.FindByNameAsync(login.Name);

                if (user != null)
                {
                    if ((await signInManager.PasswordSignInAsync(user,
                        login.Password, false, false)).Succeeded) // IsPersistance (if user close the browser, sign-in information is saved in a cookie) lockoutOnFailure (if the password failed, user cannot try again to access)
                    {
                        return Redirect(login?.ReturnUrl ?? "/Admin/Index");
                    }

                }
            }
            ModelState.AddModelError("", "Invalid name or password");
            return View(login);
        }

        public async Task<RedirectResult> Logout(string returnUrl = "/")
        {
            await signInManager.SignOutAsync();
            return Redirect(returnUrl);
        }
    }
}
