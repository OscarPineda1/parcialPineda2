using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proyecto_Parcial.Data;
using Proyecto_Parcial.Models;

namespace Proyecto_Parcial.Controllers
{
    public class RemesasController : Controller
    {
        private readonly ILogger<RemesasController> _logger;
        private readonly ApplicationDbContext _context;

        public RemesasController(ILogger<RemesasController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var remesas = from o in _context.DataRemesa select o;
            return View(remesas);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}