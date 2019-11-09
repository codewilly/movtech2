using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using movtech.Domain.Contracts.Vehicle;

namespace movtech.MVC.ViewModels.Vehicle
{
    public class UpdateVehicleViewModel : UpdateVehicleRequest
    {
        public List<SelectListItem> BrandList { get; set; } = new List<SelectListItem>();

        public List<SelectListItem> ModelList { get; set; } = new List<SelectListItem>();

        public string HiddenBrand { get; set; }

        public string HiddenModel { get; set; }

        

    }
}
