using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using movtech.Domain.Enums;
using movtech.MVC.Services.Interface;
using movtech.MVC.ViewModels.Vehicle;


namespace movtech.MVC.Controllers
{
    [Authorize]
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

        // TODO -> Esta falantando salvar o tipo de combustível!

        [HttpPost]
        public async Task<IActionResult> Create(CreateVehicleViewModel viewModel)
        {
            if (ModelState.IsValid)
            {

                viewModel.Brand = viewModel.HiddenBrand;
                viewModel.Model = viewModel.HiddenModel;

                if (await _movtechAPIService.CadastrarVeiculo(viewModel))
                {
                    ViewBag.VeiculoCadastrado = "true";
                    var vehicles = await _movtechAPIService.GetAllVeiculos();
                    return View("Index", vehicles);
                }
                else
                {
                    ModelState.AddModelError("", "Não foi possível cadastrar com os dados informados.");
                    return View(viewModel);
                }

            }
            else
            {
                return View(viewModel);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            var vehicle = await _movtechAPIService.GetVehicle(id);

            // Carregar os Dropdowns

            if (vehicle == null)
            {
                return NotFound();
            }

            // Preparar os Dropdowns
            var _brands = await _movtechAPIService.ConsultarMarcas(vehicle.VehicleType);
            var _brandId = _brands.Marcas.Where(x => x.Label == vehicle.Brand).FirstOrDefault().Value;

            var _models = await _movtechAPIService.ConsultarModelos(vehicle.VehicleType, int.Parse(_brandId));
            var _modelId = _models.Modelos.Where(x => x.Label == vehicle.Model).FirstOrDefault().Value;

            var _years = await _movtechAPIService.ConsultarAnosDoModelo(vehicle.VehicleType, int.Parse(_brandId), _modelId);
            var _yearId = _years.AnoModelos.Where(x => x.Label.Substring(0, 4) == vehicle.Year.ToString()).FirstOrDefault().Value;

            // Prepara a viewmodel
            var viewModel = new UpdateVehicleViewModel();

            viewModel.Quilometers = vehicle.Quilometers;
            viewModel.BrandList = _brands.Marcas.Select(x => new SelectListItem() { Text = x.Label, Value = x.Value }).ToList();
            viewModel.ModelList = _models.Modelos.Select(x => new SelectListItem() { Text = x.Label, Value = x.Value.ToString() }).ToList();
            viewModel.YearList = _years.AnoModelos.Select(x => new SelectListItem() { Text = x.Label.Substring(0, 4), Value = x.Value.Substring(0, 4) }).ToList();

            // Transfere os dados da classe VEHICLE para a view model UPDATEVEHICLEVIEWMODEL
            viewModel.VehicleType = vehicle.VehicleType;
            viewModel.Brand = _brandId;
            viewModel.Model = _modelId.ToString();
            viewModel.Year = int.Parse(_yearId.Substring(0, 4));

            ViewBag.Placa = vehicle.LicensePlate;
            ViewBag.Renavam = vehicle.Renavam;


            viewModel.HiddenBrand = vehicle.Brand;
            viewModel.HiddenModel = vehicle.Model;

            return View(viewModel);

        }



        [HttpPost]
        public async Task<IActionResult> Edit(int Id, UpdateVehicleViewModel viewModel)
        {

            if (ModelState.IsValid)
            {

                viewModel.Brand = viewModel.HiddenBrand;
                viewModel.Model = viewModel.HiddenModel;

                if (await _movtechAPIService.AtualizarVeiculo(Id, viewModel))
                {
                    ViewBag.VeiculoEditado = "true";
                    var vehicles = await _movtechAPIService.GetAllVeiculos();
                    return View("Index", vehicles);
                }
                else
                {
                    ModelState.AddModelError("", "Não foi possível atualizar!");

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

            // View Model
            var viewModel = new DetailsVehicleViewModel();

            viewModel.Vehicle = vehicle;

            // Percentuais
            viewModel.PercentMaintenance = vehicle.GetMaintenancePercent();//(int)Math.Round(vehicle.Quilometers / vehicle.GetNextMaintenanceKms("manutencao") * 100);
            viewModel.PercentOil = vehicle.GetOilLifePercent();//(int)Math.Round((vehicle.Quilometers / vehicle.GetNextMaintenanceKms("oleo")) * 100);
            viewModel.PercentTires = vehicle.GetTireLifePercent();//(int)Math.Round(((vehicle.Quilometers - vehicle.LastTireChangeKms) / (vehicle.GetNextMaintenanceKms("rodas") - vehicle.LastTireChangeKms)) * 100);

            //Cores (class do progress bar)
            viewModel.PercentMaintenanceClass = ProgressColorClass(viewModel.PercentMaintenance);
            viewModel.PercentOilClass = ProgressColorClass(viewModel.PercentOil);
            viewModel.PercentTiresClass = ProgressColorClass(viewModel.PercentTires);

            return View(viewModel);
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
            var _modelList = await _movtechAPIService.ConsultarModelos(type, marcaId);
            return Json(_modelList);
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


        private string ProgressColorClass(int percent)
        {
            if (percent <= 25)
                return "bg-success";

            if (percent <= 50)
                return "bg-info";

            if (percent <= 75)
                return "bg-warning";

            return "bg-danger";

        }
    }


}