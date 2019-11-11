using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using movtech.Domain.Contracts.Vehicle;
using movtech.MVC.Services.Interface;
using movtech.MVC.ViewModels;
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
            var driver = await _movtechAPIService.GetDriver(id);
            return View(new EditDriverViewModel()
            {
                Id = id,
                BirthDate = driver.BirthDate,
                CEP = driver.CEP, 
                City = driver.City,
                CNHCategory = driver.CNHCategory,
                Email = driver.Email,
                Name = driver.Name,
                Neighborhood = driver.Neighborhood,
                Number = driver.Number,
                Phone = driver.Phone,
                Street = driver.Street,
                UF = driver.UF,
                

            });
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditDriverViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (await _movtechAPIService.AtualizarMotorista(viewModel.Id, viewModel))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Não foi possível atualizar!");

                    return View(viewModel);

                }
            }
            else
            {
                return View(viewModel);
            }
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