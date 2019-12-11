using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace E_ChargerInternational.Controllers
{
    public class AdministratoriaiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult Create()
        //{
        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(object Rezervacija)
        //{
        //    return View();
        //}
        //public IActionResult Edit()
        //{
        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(object Rezervacija)
        //{
        //    return View();
        //}
    }
}