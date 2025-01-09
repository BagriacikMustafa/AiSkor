using AiSkor.Models;
using AiSkor.Models.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace AiSkor.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetMatchesByDate(string date)
        {
            try
            {
                if (!DateTime.TryParse(date, out DateTime parsedDate))
                {
                    return Json(new { error = "Ge�ersiz tarih format�." });
                }

                var matches = _context.MacSonuclari
                    .Where(m => m.Tarih.Date == parsedDate.Date)
                    .OrderBy(m => m.Saat) // Saat bilgisine g�re s�ralama
                    .Select(m => new
                    {
                        Saat = m.Saat.ToString(@"hh\:mm"), // TimeSpan formatlama
                        Takim1 = m.Takim1,
                        Takim2 = m.Takim2,
                        Skor1 = m.Skor1,
                        Skor2 = m.Skor2,
                        IlkYariSkoru = m.IlkYariSkoru,
                        Lig = m.Lig
                    })
                    .ToList();

                if (!matches.Any())
                {
                    return Json(new { error = "Bu tarihe ait ma� sonucu bulunamad�." });
                }

                return Json(matches);
            }
            catch (Exception ex)
            {
                return Json(new { error = "Bir hata olu�tu: " + ex.Message });
            }
        }
    }
}
