using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using movtech.Domain.Contracts.InsurenceClaim;
using movtech.Domain.Entities;
using movtech.MVC.Services.Interface;
using movtech.MVC.ViewModels.InsurenceClaim;

namespace movtech.MVC.Controllers
{
    [Authorize]
    public class InsurenceClaimsController : Controller
    {
        private readonly IMovtechAPIService _movtechAPIService;

        public InsurenceClaimsController(IMovtechAPIService movtechAPIService)
        {
            _movtechAPIService = movtechAPIService;

        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<InsurenceClaim> insurenceClaims = await _movtechAPIService.GetAllInsurenceClaims();
            return View(insurenceClaims);
        }

        public async Task<IActionResult> Details(int id)
        {
            InsurenceClaim insurence = await _movtechAPIService.GetInsurenceClaim(id);

            return View(insurence);
        }
       
        public async Task<IActionResult> Create()
        {
            

            CreateInsurenceClaimViewModel viewModel = new CreateInsurenceClaimViewModel();
            viewModel.Insurences = await _movtechAPIService.GetAllInsurences();
            return View(viewModel);
        }
        public async Task<IActionResult> RegisterInsurenceClaim(CreateInsurenceClaimViewModel viewModel)
        {


            CreateInsurenceClaimRequest request = new CreateInsurenceClaimRequest()
            {
                DriverCPF = viewModel.DriverCPF,
                InsurenceId = viewModel.InsurenceId,
                InsurenceClaimDate = viewModel.InsurenceClaimDate,
                OccurrenceNumber = viewModel.OccurrenceNumber,
                Observation = viewModel.Observation,
                InsurenceClaimNumber = viewModel.InsurenceClaimNumber,
                InsurenceClaimType = viewModel.InsurenceClaimType,

                CEP = viewModel.CEP,
                Street = viewModel.Street,
                Number = viewModel.Number,
                Neighborhood = viewModel.Neighborhood,
                City = viewModel.City,
                UF = viewModel.UF,
            };

            if (await _movtechAPIService.CreateInsurenceClaim(request))
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError("", "Não foi possível Criar o Seguro ");

                
                viewModel.Insurences = await _movtechAPIService.GetAllInsurences();
                
                return View("Create", viewModel);
            }
        }

    }
}