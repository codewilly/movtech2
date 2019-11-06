using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using movtech.Domain.Enums;
using movtech.MVC.Services.Interface;
using movtech.MVC.ViewModels.Vehicle;


namespace movtech.MVC.Controllers
{
    public class VehiclesController : Controller
    {

        #region Config

        private readonly IMovtechAPIService _movtechAPIService;

        public VehiclesController(IMovtechAPIService movtechAPIService)
        {
            _movtechAPIService = movtechAPIService;
        }

        #endregion

        [HttpGet]
        public async Task<IActionResult> Index()
        {

            var vehicles = await _movtechAPIService.GetAllVeiculos();
            return View(vehicles);
        }

        [HttpGet]
        public IActionResult Create()
        {

            var viewModel = new CreateVehicleViewModel();

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateVehicleViewModel viewModel)
        {
            if (ModelState.IsValid)
            {

                viewModel.Brand = viewModel.HiddenBrand;
                viewModel.Model = viewModel.HiddenModel;

                if (await _movtechAPIService.CadastrarVeiculo(viewModel))
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
        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var vehicle = await _movtechAPIService.GetVehicle(id.Value);
            if (vehicle == null)
            {
                return NotFound();
            }

            
            var viewModel = new UpdateVehicleViewModel();

            // Transfere os dados da classe VEHICLE para a view model UPDATEVEHICLEVIEWMODEL
            viewModel.Brand = vehicle.Brand;
            viewModel.Model = vehicle.Model;
            viewModel.Year = vehicle.Year;

            viewModel.Quilometers = vehicle.Quilometers;
            viewModel.FuelType = vehicle.FuelType;
            viewModel.VehicleType = vehicle.VehicleType;
            
            
            
            
            
            
            
            
            
            return View(viewModel);



        }
        [HttpPost]
        public async Task<IActionResult> Edit(int Id,UpdateVehicleViewModel viewModel )
        {
            
            if (ModelState.IsValid)
            {
                
                viewModel.Brand = viewModel.HiddenBrand;
                viewModel.Model = viewModel.HiddenModel;
                
                if (await _movtechAPIService.AtualizarVeiculo(Id,viewModel))
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
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var vehicle = await _movtechAPIService.GetVehicle(id.Value);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }


        #region Dropdowns Ajax

        [HttpGet]
        public async Task<JsonResult> GetMarcas(VehicleType type)
        {
            var _brandList = await _movtechAPIService.ConsultarMarcas(type);
            return Json(_brandList);
        }

        [HttpGet]
        public async Task<JsonResult> GetModels(VehicleType type, int marcaId)
        {
            var _brandList = await _movtechAPIService.ConsultarModelos(type, marcaId);
            return Json(_brandList);
        }

        [HttpGet]
        public async Task<JsonResult> GetModelYears(VehicleType type, int marcaId, int modeloId)
        {
            var _yearList = await _movtechAPIService.ConsultarAnosDoModelo(type, marcaId, modeloId);

            foreach (var item in _yearList.AnoModelos)
            {
                item.Label = item.Label.Substring(0, 4);
                item.Value = item.Value.Substring(0, 4);
            }

            return Json(_yearList);
        }
        #endregion
    }

   
}