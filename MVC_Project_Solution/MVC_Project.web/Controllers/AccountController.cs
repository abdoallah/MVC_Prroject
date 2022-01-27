using MVC_Project.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Identity;
using MVC_Project.EF.Extend;
using System.Threading.Tasks;
using MVC_Project.Core.Helper;

namespace Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;


        public AccountController(UserManager<ApplicationUser> userManager, 
            SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;

        }

        #region Registration(Sign up)

        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registration(RegistrationVM model)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    var user = new ApplicationUser()
                    {
                        Email = model.Email,
                        UserName = model.Email,
                        IsAgree = model.IsAgree
                    };

                   var result = await userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Login");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }


                }


                return View(model);

            }
            catch (Exception ex)
            {

                return View(model);

            }
        }
        
        
        #endregion


        #region Login(Sign in)

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Invaild username or password");
                    }

                }
                return View(model);

            }
            catch (Exception ex)
            {

                return View(model);

            }
        }



        #endregion


        #region Log off(Sign out)
        [HttpPost]
        public async Task<IActionResult> LogOff()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }





        #endregion


        #region Forget Password

        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordVM model)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    //get user by mail 
                    var user = await userManager.FindByEmailAsync(model.Email);

                    if (User != null)
                    {
                        //if user exists generate token
                        var token = await userManager.GeneratePasswordResetTokenAsync(user);

                        //Generate reset link
                        var PasswordResetLink = Url.Action("ResetPassword", "Account",
                                                new { Email = model.Email, Token = token }, Request.Scheme);

                        //Send Mail
                        MailSender.SendMail(new MailVM()
                        {
                            Title= "Feane - Reset Password",
                            Message = PasswordResetLink,
                            Email = model.Email
                        });

                        return RedirectToAction("ConfirmForgetPassword");
                    }
                }

                return RedirectToAction("ConfirmForgetPassword");

            }
            catch (Exception ex)
            {

                return View(model);

            }
        }




        [HttpGet]
        public IActionResult ConfirmForgetPassword()
        {
            return View();
        }


        #endregion


        #region Reset Password

        [HttpGet]
        public IActionResult ResetPassword(string Email, string Token)
        {
            if (Email !="" && Token != "")
            {
                return View();
            }
            return RedirectToAction("Login");
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM model)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    var user = await userManager.FindByEmailAsync(model.Email);

                    if (user != null)
                    {
                        var result = await userManager.ResetPasswordAsync(user, model.Token, model.Password);

                    }

                }
                return View(model);

            }
            catch (Exception ex)
            {

                return View(model);

            }
        }



        [HttpGet]
        public IActionResult ConfirmResetPassword()
        {
            return View();
        }

        #endregion



    }
}
