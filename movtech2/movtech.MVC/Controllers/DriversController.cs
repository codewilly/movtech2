using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using movtech.Domain.Contracts.Vehicle;
using movtech.MVC.Services.Interface;
using movtech.MVC.ViewModels.Driver;

namespace movtech.MVC.Controllers
{
    public class DriversController : Controller
    {

        #region Config

        private readonly IMovtechAPIService _movtechAPIService;
        private readonly IViaCepService _viaCepService;

        public DriversController(IMovtechAPIService movtechAPIService, IViaCepService viaCepService)
        {
            _movtechAPIService = movtechAPIService;
            _viaCepService = viaCepService;
        }

        #endregion


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var drivers = await _movtechAPIService.GetAllDrivers();
            return View(drivers);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            

            var viewModel = new CreateDriverViewModel();

            return View(viewModel);
        }
        
        [HttpPost]
        public async Task<IActionResult> Create(CreateDriverViewModel viewModel)
        {

            if (ModelState.IsValid)
            {
                               
                if (await _movtechAPIService.CadastarMotorista(viewModel))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Não foi possível cadastrar!");
                    return View(viewModel);
                }

            }
            else
            {
                return View(viewModel);
            }



                
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var motorista = await _movtechAPIService.GetDriver(id);
            return View(motorista);
        }

        #region AJAX

        public async Task<JsonResult> SearchCep(string cep)
        {
            var response = await _viaCepService.SearchCep(cep);
            return Json(response);
        }

        #endregion

    }
}