using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eentitie = movtech.Domain.Entities;

namespace movtech.API.ViewModels.EntranceAndExit
{
    public class EntranceExitResponseViewModel
    {

        public Eentitie.EntranceAndExit Response { get; set; }

        public List<string> Messages { get; set; }


    }
}
