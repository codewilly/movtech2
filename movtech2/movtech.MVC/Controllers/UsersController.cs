using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using movtech.Domain.Contracts.User;
using movtech.MVC.Services.Interface;

namespace movtech.MVC.Controllers
{
    public class UsersController : Controller
    {

        #region Config

        private readonly IMovtechAPIService _movtechAPIService;

        public UsersController(IMovtechAPIService movtechAPIService)
        {
            _movtechAPIService = movtechAPIService;
        }

        #endregion

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind] UserLoginRequest request)
        {
            var user = await _movtechAPIService.Login(request);

            if (user != null)
            {

                var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.NameIdentifier, request.CPF),
                        new Claim(ClaimTypes.Name, user.Name)

                    };

                ClaimsIdentity userIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                await HttpContext.SignInAsync(principal);


                return RedirectToAction("Index", "Home");

                //if (User.Identity.IsAuthenticated)
                //    return RedirectToAction("Index", "Home");
                //else
                //{
                //    ModelState.AddModelError("", "Erro ao tentar logar-se");
                //    return View(request);
                //}

            }
            else
            {
                ModelState.AddModelError("", "Usuário ou senha inválido");
                return View(request);
            }


        }


        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}