using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EChargerInternational.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_ChargerInternational.Controllers
{
    public class NaudotojaiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Naudotojas user)
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Naudotojas user)
        {
            return View();
        }
        public IActionResult BlockUser(int id)
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}