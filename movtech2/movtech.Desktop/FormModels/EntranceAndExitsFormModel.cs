using System;
using System.ComponentModel;


namespace movtech.Desktop
{
    public class EntranceAndExitsFormModel
    {
        [DisplayName("Data")]
        public DateTime CreationDate { get; set; }
        [DisplayName("Marca")]
        public string VehicleBrand { get; set; }
        [DisplayName("Descrição")]
        public string  Description { get; set; }
    }
}
