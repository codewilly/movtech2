using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using movtech.MVC.Services.Interface;
using movtech.MVC.ViewModels.Maps;

namespace movtech.MVC.Controllers
{
    [Authorize]
    public class MapsController : Controller
    {

        #region Config

        private readonly IMovtechAPIService _movtechAPIService;

        public MapsController(IMovtechAPIService movtechAPIService)
        {
            _movtechAPIService = movtechAPIService;
        }

        #endregion

        public async Task<IActionResult> Index()
        {
            
            return View();
        }

        public async Task<JsonResult> GetLocalizations()
        {
            var vehicles = await _movtechAPIService.GetAllVeiculos();

            if (vehicles != null)
            {

            

            List<object> retorno = new List<object>();

            int i = 0;
            foreach (var v in vehicles)
            {
                i++;
                object[] row = { v.LicensePlate, v.Latitude, v.Longitude, i };
                retorno.Add(row);
            }

            return Json(retorno.ToArray());
            }
            else
            {
                return null;
            }

        }
    }
}