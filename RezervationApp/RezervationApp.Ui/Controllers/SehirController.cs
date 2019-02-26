using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RezervationApp.Bll.Abstract;

namespace RezervationApp.Ui.Controllers
{
    public class SehirController : Controller
    {
        ISehirService service;
        public SehirController(ISehirService _service)
        {
            service = _service;
        }
        public IActionResult Index()
        {
          var list=   service.GetList();
            return View(list);
        }
    }
}