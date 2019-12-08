using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using movtech.Domain.Contracts.Maintenance;
using movtech.Domain.Entities;
using movtech.MVC.Services.Interface;
using movtech.MVC.ViewModels.Maintenance;

namespace movtech.MVC.Controllers
{
    public class MaintenancesController : Controller
    {

        #region Config

        private readonly IMovtechAPIService _movtechAPIService;


        public MaintenancesController(IMovtechAPIService movtechAPIService)
        {
            _movtechAPIService = movtechAPIService;
        }

        #endregion

        public async Task<IActionResult> Index()
        {
            var drivers = await _movtechAPIService.GetVehiclesWhoNeedsMaintenance();
            return View(drivers);
        }

        public async Task<IActionResult> Create(int id)
        {
            var vehicle = await _movtechAPIService.GetVehicle(id);

            if (vehicle != null)
            {
                ViewBag.Placa = vehicle.LicensePlate;
                ViewBag.Marca = vehicle.Brand;
                ViewBag.Modelo = vehicle.Model;

                var viewModel = new RegisterMaintenanceViewModel()
                {
                    VehicleId = id
                };

                return View(viewModel);

            }
            else
            {
                return View();
            }


        }

        public async Task<IActionResult> PerformMaintenance(RegisterMaintenanceViewModel viewModel)
        {

            var _vehicle = await _movtechAPIService.GetVehicle(viewModel.VehicleId);

            if (_vehicle != null)
            {
                var request = new RegisterMaintenanceRequest()
                {
                    LicensePlate = _vehicle.LicensePlate,
                    Cost = viewModel.Cost,
                    OilChanged = viewModel.OilChanged,
                    OperationDescription = viewModel.OperationDescription,
                    PreventivaOrCorretiva = viewModel.PreventivaOrCorretiva,
                    TiresChanged = viewModel.TiresChanged
                };

                var success = await _movtechAPIService.RegisterMaintenance(request);

                if (success)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Ocorreu um erro ao registrar a manutenção!");
                    return View(ModelState);
                }
            }
            else
            {
                ModelState.AddModelError("", "Veículo não encontrado!");
                return View(ModelState);

            }

            




        }
    }
}