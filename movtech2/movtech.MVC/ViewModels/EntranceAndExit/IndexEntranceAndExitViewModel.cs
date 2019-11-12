using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movtech.MVC.ViewModels.EntranceAndExit
{
    public class IndexEntranceAndExitViewModel
    {
        public IEnumerable<Domain.Entities.EntranceAndExit> EntradasSaidas { get; set; }

        public string CpfExit { get; set; }

        public string LicencePlateExit { get; set; }

        public string CpfEntrance { get; set; }

        public string LicencePlateEntrance { get; set; }

        public float QuilometersEntrance{ get; set; }



    }
}
