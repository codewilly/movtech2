using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using movtech.MVC.Services.Interface;

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

            ViewBag.Placa = vehicle.LicensePlate;
            ViewBag.Marca = vehicle.Brand;
            ViewBag.Modelo = vehicle.Model;

            return View();
        }
    }
}