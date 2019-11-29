using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using movtech.MVC.Services.Interface;
using movtech.MVC.ViewModels.TrafficTicket;

namespace movtech.MVC.Controllers
{
    public class TrafficTicketsController : Controller
    {
        private readonly IMovtechAPIService _movtechAPIService;
        

        public TrafficTicketsController(IMovtechAPIService movtechAPIService)
        {
            _movtechAPIService = movtechAPIService;
            
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<TrafficTicketIndexViewModel> trafficTickets;

            trafficTickets = await _movtechAPIService.ConsultarMultas();

            return View(trafficTickets);
        }

        
        [HttpGet]
        public IActionResult Create()
        {


            var viewModel = new CreateTrafficTicketViewModel();

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTrafficTicketViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if(await _movtechAPIService.CadastrarMulta(viewModel)){
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError("", "Não foi possível cadastrarrrr!");
                    return View(viewModel);
                }
                
            }
            else
            {
                return View(viewModel);
            }



            return View(viewModel);
        }
    }
}