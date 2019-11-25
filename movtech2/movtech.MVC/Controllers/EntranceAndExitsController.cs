using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using movtech.Domain.Contracts.EntranceAndExit;
using movtech.MVC.Services.Interface;
using movtech.MVC.ViewModels.EntranceAndExit;

namespace movtech.MVC.Controllers
{
    public class EntranceAndExitsController : Controller
    {

        #region Config

        private readonly IMovtechAPIService _movtechAPIService;

        public EntranceAndExitsController(IMovtechAPIService movtechAPIService)
        {
            _movtechAPIService = movtechAPIService;

        }

        #endregion

        public async Task<IActionResult> Index()
        {

            var viewModel = new IndexEntranceAndExitViewModel()
            {
                EntradasSaidas = await _movtechAPIService.GetAllEntranceAndExit()
            };
            
            return View(viewModel);
        }

        public async Task<IActionResult> Exit(IndexEntranceAndExitViewModel viewModel)
        {
            var result = await _movtechAPIService.RegisterExit(new RegisterExitRequest()
            {
                DriverCPF = viewModel.CpfExit,
                LicensePlate = viewModel.LicencePlateExit

            });            

            if (!result)
            {
                ModelState.AddModelError("", "Não foi possível registrar a saída!");
                viewModel.EntradasSaidas = await _movtechAPIService.GetAllEntranceAndExit();
                return View("Index", viewModel);
            }

            return RedirectToAction("Index");
        }
        
        public async Task<IActionResult> Entrance(IndexEntranceAndExitViewModel viewModel)
        {
            var result = await _movtechAPIService.RegisterEntrance(new RegisterEntranceRequest()
            {
                DriverCPF = viewModel.CpfEntrance,
                LicensePlate = viewModel.LicencePlateEntrance,
                Quilometers = viewModel.QuilometersEntrance

            });

            if (!result)
            {
                ModelState.AddModelError("", "Não foi possível registrar a entrada!");
                viewModel.EntradasSaidas = await _movtechAPIService.GetAllEntranceAndExit();
                return View("Index", viewModel);
            }

            return RedirectToAction("Index");
        }
    }
}