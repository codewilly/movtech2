using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using movtech.Domain.Contracts.Refuel;
using movtech.Domain.Entities;
using movtech.MVC.Services.Interface;
using movtech.MVC.ViewModels.Refuel;

namespace movtech.MVC.Controllers
{
    [Authorize]
    public class RefuelsController : Controller
    {

        #region Config

        private readonly IMovtechAPIService _movtechAPIService;

        public RefuelsController(IMovtechAPIService movtechAPIService)
        {
            _movtechAPIService = movtechAPIService;
        }

        #endregion

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var viewModel = new RefuelIndexViewModel()
            {
                Postos = await GetPostos()
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> RegisterRefuel(RefuelIndexViewModel viewModel)
        {

            var request = new RegisterRefuelRequest()
            {
                DriverCPF = viewModel.CPF,
                FuelType = viewModel.FuelType,
                GasStationCNPJ = viewModel.CNPJ,
                Liters = viewModel.Liters,
                LiterValue = viewModel.LiterValue,
                RefuelDate = viewModel.RefuelDate,
                TotalValue = viewModel.TotalValue,
                VehicleLicensePlate = viewModel.LicensePlate
            };

            var success = await _movtechAPIService.RegisterRefuel(request);

            if (success)
            {
                ViewBag.RegisterSuccess = "true";
            }

            viewModel.Postos = await GetPostos();
            return View("Index", viewModel);
        }

        [HttpGet]
        public IActionResult CreateGasStation()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateGasStation(GasStation gs)
        {

            var request = new CreateGasStationRequest()
            {
                CNPJ = gs.CNPJ,
                Name = gs.Name,
                CEP = gs.CEP,
                City = gs.City,
                Neighborhood = gs.Neighborhood,
                Number = gs.Number,
                Street = gs.Street,
                UF = gs.UF
            };

            var success = await _movtechAPIService.CreateGasStation(request);

            var viewModel = new RefuelIndexViewModel()
            {
                Postos = await GetPostos()
            };

            ViewBag.PostoCriado = "true";

            return View("Index", viewModel);
        }


        private async Task<List<SelectListItem>> GetPostos()
        {
            var listaPostos = new List<SelectListItem>();
            var postos = await _movtechAPIService.GetGasStations();

            postos.ToList().ForEach(p =>
            {
                listaPostos.Add(new SelectListItem()
                {
                    Text = p.Name,
                    Value = p.CNPJ
                });
            });

            return listaPostos;
        }
    }
}