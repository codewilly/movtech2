using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Entities
{
    public class Driver : Person
    {
        public string CNH { get; set; }

        public string CNHCategory { get; set; }

        public int VehicleId { get; set; }

        public Vehicle Vehicle { get; set; }

        

        #region Methods

        
        #endregion
    }
}
