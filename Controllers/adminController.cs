using AiSkor.Models; // Slider modeline erişim için
using AiSkor.Models.Context; // Veritabanı bağlamı
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AiSkor.Controllers
{
    public class adminController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
