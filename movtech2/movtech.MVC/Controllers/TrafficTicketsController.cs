using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using movtech.Domain.Entities;
using movtech.MVC.Services.Interface;
using movtech.MVC.ViewModels.TrafficTicket;

namespace movtech.MVC.Controllers
{
    [Authorize]
    public class TrafficTicketsController : Controller
    {
        private readonly IMovtechAPIService _movtechAPIService;
        

        public TrafficTicketsController(IMovtechAPIService movtechAPIService)
        {
            _movtechAPIService = movtechAPIService;
            
        }
        public async Task<IActionResult> Index(string payed)
        {
            IEnumerable<TrafficTicket> trafficTickets;

            trafficTickets = await _movtechAPIService.ConsultarMultas();

            ViewBag.Payed = payed;

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
                    ModelState.AddModelError("", "Não foi possível cadastrar!");
                    return View(viewModel);
                }
                
            }
            else
            {
                return View(viewModel);
            }



           
        }
        public async Task<IActionResult> Details(TrafficTicket trafficTicket)
        {
            TrafficTicket ticket = await _movtechAPIService.ConsultarMulta(trafficTicket.Id);

            return View(ticket);
        }

        
        public async Task<IActionResult> Pay(TrafficTicket trafficTicket)
        {
            await _movtechAPIService.PagarMulta(trafficTicket.Id);


            return RedirectToAction("Index");

            
        }

    }
}