using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Contracts.Driver
{
    public class UpdateLocalizationRequest
    {
        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}
