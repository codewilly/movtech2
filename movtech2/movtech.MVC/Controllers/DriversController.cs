using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using movtech.MVC.Services.Interface;
using movtech.MVC.ViewModels.Driver;

namespace movtech.MVC.Controllers
{
    public class DriversController : Controller
    {

        #region Config

        private readonly IMovtechAPIService _movtechAPIService;

        public DriversController(IMovtechAPIService movtechAPIService)
        {
            _movtechAPIService = movtechAPIService;
        }

        #endregion


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var drivers = await _movtechAPIService.GetAllDrivers();
            return View(drivers);
        }

        [HttpGet]
        public IActionResult Create()
        {

            var viewModel = new CreateDriverViewModel();

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            return View();
        }


    }
}