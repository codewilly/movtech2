﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace movtech.MVC.Controllers
{
    [Authorize]
    public class SinistrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}