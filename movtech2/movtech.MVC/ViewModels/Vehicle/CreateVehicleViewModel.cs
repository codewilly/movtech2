using Microsoft.AspNetCore.Mvc.Rendering;
using movtech.Domain.Contracts.Vehicle;
using movtech.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace movtech.MVC.ViewModels.Vehicle
{
    public class CreateVehicleViewModel : CreateVehicleRequest
    {

        public List<SelectListItem> BrandList { get; set; } = new List<SelectListItem>();

        public List<SelectListItem> ModelList { get; set; } = new List<SelectListItem>();

        public string HiddenBrand { get; set; }

        public string HiddenModel { get; set; }


    }
}
