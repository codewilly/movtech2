﻿using movtech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Interfaces.Services
{
    public interface IDriverService : IBaseService<Driver>
    {
        Driver GetByCPF(string cpf);
    }
}