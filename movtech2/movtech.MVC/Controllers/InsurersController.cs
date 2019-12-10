using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using movtech.Domain.Entities;
using movtech.MVC.Services.Interface;
using movtech.MVC.ViewModels.Insurer;

namespace movtech.MVC.Controllers
{
    [Authorize]
    public class InsurersController : Controller
    {
        private readonly IMovtechAPIService _movtechAPIService;

        public InsurersController(IMovtechAPIService movtechAPIService)
        {
            _movtechAPIService = movtechAPIService;

        }
        public async Task<IActionResult> Index()
        {

            IEnumerable<Insurer> _insurers = await _movtechAPIService.GetAllInsurers();
            return View(_insurers);
        }

        public IActionResult Create()
        {

            CreateInsurerViewModel viewModel = new CreateInsurerViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateInsurerViewModel viewModel)
        {

            if(ModelState.IsValid)
            {
                if(await _movtechAPIService.CreateInsurer(viewModel))
                {
                    return RedirectToAction(nameof(Index));
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
        public async Task<IActionResult> Details(int id)
        {

            Insurer insurer = await _movtechAPIService.GetInsurer(id);
            return View(insurer);


        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            Insurer insurer = await _movtechAPIService.GetInsurer(id);
            return View(insurer);


        }

        [HttpPost]
        public async Task<IActionResult> Edit(Insurer insurer)
        {
            if (ModelState.IsValid)
            {
                UpdateInsurerViewModel viewModel = new UpdateInsurerViewModel()
                {
                    Phone = insurer.Phone,
                    Name = insurer.Name,
                    Email = insurer.Email,

                    CEP = insurer.CEP,
                    Street = insurer.Street,
                    Neighborhood = insurer.Neighborhood,
                    UF = insurer.UF,
                    City = insurer.City,
                    Number = insurer.Number

                };

                if (await _movtechAPIService.AtualizarSeguradora(insurer.Id, viewModel))
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError("", "Não Foi possível Atualizar a Corretora");
                    return View(insurer);
                }

            }
            else
            {
                
                return View(insurer);
            }

            
           


        }

    }
}