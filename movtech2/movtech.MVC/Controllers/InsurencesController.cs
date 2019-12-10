using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using movtech.Domain.Contracts.Insurence;
using movtech.Domain.Entities;
using movtech.Domain.Services;
using movtech.MVC.Services.Interface;
using movtech.MVC.ViewModels.Insurence;
using Microsoft.AspNetCore.Mvc.Rendering;


using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;

namespace movtech.MVC.Controllers
{
    [Authorize]
    public class InsurencesController : Controller
    {
        private readonly IMovtechAPIService _movtechAPIService;




        public InsurencesController(IMovtechAPIService movtechAPIService)
        {
            _movtechAPIService = movtechAPIService;

        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Insurence> insurences = await _movtechAPIService.GetAllInsurences();

            return View(insurences);
        }

        public async Task<IActionResult> Create()
        {



            var viewModel = new InsurenceCreateViewModel();
            viewModel.Vehicles = await _movtechAPIService.GetAllVeiculos();
            viewModel.Insurers = await _movtechAPIService.GetAllInsurers();
            viewModel.Brokers = await _movtechAPIService.GetAllBrokers();






            return View(viewModel);
        }
        
        public async Task<IActionResult> CreateInsurence(InsurenceCreateViewModel viewModel)
        {

            CreateInsurenceRequest request = new CreateInsurenceRequest()
            {
                BeginOfVigency = viewModel.BeginOfVigency,
                EndOfVigency = viewModel.EndOfVigency,
                BonusClass = viewModel.BonusClass,
                CINumber = viewModel.CINumber,
                PolicyNumber = viewModel.PolicyNumber,
                VehicleId = viewModel.VehicleId,
                BrokerId = viewModel.BrokerId,
                InsurerId = viewModel.InsurerId
            }
            ;

            if (await _movtechAPIService.CreateInsurence(request))
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError("", "Não foi possível Criar o Seguro ");
               
                viewModel.Vehicles = await _movtechAPIService.GetAllVeiculos();
                viewModel.Insurers = await _movtechAPIService.GetAllInsurers();
                viewModel.Brokers = await _movtechAPIService.GetAllBrokers();
                return View("Create",viewModel);
            }




        }

        public async Task<IActionResult> Details(int id)
        {



            Insurence insurence = await _movtechAPIService.GetInsurence(id);



            return View(insurence);
        }

    }
}