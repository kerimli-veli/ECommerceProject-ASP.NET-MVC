using Azure.Identity;
using ECommerce.WebUI.Entities;
using ECommerce.WebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace ECommerce.WebUI.Controllers;


    public class AccountController : Controller
    {
        private readonly UserManager<CustomIdentityUser> _userManager;
        private readonly RoleManager<CustomIdentityRole> _roleManager;
        private readonly SignInManager<CustomIdentityUser> _signinManager;
    public AccountController(RoleManager<CustomIdentityRole> roleManager, UserManager<CustomIdentityUser> userManager, SignInManager<CustomIdentityUser> signinManager)
    {
        _roleManager = roleManager;
        _userManager = userManager;
        _signinManager = signinManager;
    }

    [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Register(RegisterViewModel  model)
        {
            CustomIdentityUser user = new()
            {
                UserName = model.Username,
                Email = model.Email
            };

            IdentityResult result = _userManager.CreateAsync(user, model.Password).Result;
            if (result.Succeeded)
            {
                if (!_roleManager.RoleExistsAsync("Admin" ).Result) 
                {
                    CustomIdentityRole role = new()
                    {
                        Name = "Admin"
                    };

                    IdentityResult roleResult = _roleManager.CreateAsync(role).Result;

                    if (!roleResult.Succeeded)
                    {
                        ModelState.AddModelError("", "We cannot create the role");
                        return View(model);
                    }
                }
                _userManager.AddToRoleAsync(user, "Admin").Wait();
                return RedirectToAction("Index", "");

            }

            return View(model);
        }


    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            var result = _signinManager.PasswordSignInAsync(model.UserName , model.Password , model.RememberMe , false).Result;


            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Product");
            }
            ModelState.AddModelError("", "Invalid login");
        }

        return View(model);
    }


}



