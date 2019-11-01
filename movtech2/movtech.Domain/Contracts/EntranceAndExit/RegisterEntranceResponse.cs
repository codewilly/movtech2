using System;
using System.Collections.Generic;
using System.Text;
using Eentitie = movtech.Domain.Entities;

namespace movtech.Domain.Contracts.EntranceAndExit
{
    public class RegisterEntranceResponse
    {
        public Eentitie.EntranceAndExit Response { get; set; }

        //public int param1 { get; set; }

        //public string param2 { get; set; }

        //public DateTime etcetcetc { get; set; }

        public List<string> Messages { get; set; }
    }
}
