using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using movtech.Domain.Contracts.Refuel;
using movtech.Domain.Entities;
using movtech.MVC.Services.Interface;

namespace movtech.MVC.Controllers
{
    public class RefuelsController : Controller
    {

        private readonly IMovtechAPIService _movtechAPIService;


        public RefuelsController(IMovtechAPIService movtechAPIService)
        {
            _movtechAPIService = movtechAPIService;
  
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateGasStation()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateGasStation(GasStation viewModel)
        {

            var request = new CreateGasStationRequest()
            {
                CNPJ = viewModel.CNPJ,
                Name = viewModel.Name,
                CEP = viewModel.CEP,
                City = viewModel.City,
                Neighborhood = viewModel.Neighborhood,
                Number = viewModel.Number,
                Street = viewModel.Street,
                UF = viewModel.UF
            };

            var success = await _movtechAPIService.CreateGasStation(request);


            return View();
        }
    }
}