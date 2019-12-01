using movtech.Domain.Contracts.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movtech.MVC.ViewModels
{
    public class EditDriverViewModel : UpdateDriverRequest
    {
        public int Id { get; set; }
    }
}
