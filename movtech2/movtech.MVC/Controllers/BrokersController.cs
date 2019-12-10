using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using movtech.Domain.Entities;
using movtech.MVC.Services.Interface;
using movtech.MVC.ViewModels.Broker;

namespace movtech.MVC.Controllers
{
    [Authorize]
    public class BrokersController : Controller
    {
        private readonly IMovtechAPIService _movtechAPIService;




        public BrokersController(IMovtechAPIService movtechAPIService)
        {
            _movtechAPIService = movtechAPIService;

        }

        public async Task<IActionResult> Index()
        {
            
            IEnumerable<Broker> brokers = await _movtechAPIService.GetAllBrokers();
            return View(brokers);
        }

        public IActionResult Create()
        {

            var viewModel = new CreateBrokerViewModel();

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBrokerViewModel viewModel)
        {

            if (ModelState.IsValid)
            {
                if (await _movtechAPIService.CreateBroker(viewModel))
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
        public async Task<IActionResult> Details(int id)
        {

            Broker broker = await _movtechAPIService.GetBroker(id);
            return View(broker);


        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            Broker broker = await _movtechAPIService.GetBroker(id);
            return View(broker);


        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,Broker broker)
        {
            if (ModelState.IsValid)
            {
                UpdateBrokerViewModel viewModel = new UpdateBrokerViewModel()
                {
                    Phone = broker.Phone,
                    Name = broker.Name,
                    Email = broker.Email,
                    ResponsibleBroker = broker.ResponsibleBroker,

                    CEP = broker.CEP,
                    Street = broker.Street,
                    Neighborhood = broker.Neighborhood,
                    UF = broker.UF,
                    City = broker.City,
                    Number = broker.Number

                };

                if (await _movtechAPIService.AtualizarCorretora(broker.Id, viewModel))
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError("", "Não Foi possível Atualizar a Corretora");
                    return View(broker);
                }

            }
            else
            {

                return View(broker);
            }
           


        }

    }
}