﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DALKilikyaOlive.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PLKilikyaOlive.Models;

namespace PLKilikyaOlive.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Login(UserSignInViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);

            if (result.Succeeded)
                return RedirectToAction("Index", "Home");
            else
                return RedirectToAction("Index", "Login");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserSignUpViewModel model)
        {
            string phoneNumber = new String(model.PhoneNumber.Where(Char.IsDigit).ToArray());

            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser
                {
                    Name = model.Name,
                    SurName = model.SurName,
                    Email = model.Email,
                    UserName = model.UserName,
                    PhoneNumber = phoneNumber
                };

                var result = await _userManager.CreateAsync(appUser, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                //foreach (var error in result.Errors)
                //{
                //    ModelState.AddModelError("", error.Description);
                //}
            }

            return View(model);
        }
    }
}
