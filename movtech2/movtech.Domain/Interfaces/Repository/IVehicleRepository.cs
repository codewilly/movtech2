﻿using movtech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Interfaces.Repository
{
    public interface IVehicleRepository : IBaseRepository<Vehicle>
    {
        Vehicle GetByLicensePlate(string lp);
    }
}
