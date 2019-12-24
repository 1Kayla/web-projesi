using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GirOr.Controllers
{
    [Authorize(Roles = "SUPERADMIN")]
    public class AdminController : Controller
    {

        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult Ekle()
        {
           
            return View();
        }
        [Authorize(Roles = "SUPERADMIN")] 
        public IActionResult Duzenle()
        {
            return View();
        }
        [Authorize(Roles = "SUPERADMIN")]
        public IActionResult Sil()
        {
            return View();
        }
        public IActionResult Listele()
        {
            return View();
        }
    }
}