using Microsoft.AspNetCore.Mvc;
using AiSkor.Models;
using AiSkor.Models.Context;

namespace AiSkor.Controllers
{
    public class PuanDurumuController : Controller
    {
        private readonly AppDbContext _context;

        public PuanDurumuController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Varsayılan olarak en son haftayı gösterebiliriz
            var sonHafta = _context.PuanDurumu.Max(p => p.Hafta);
            return RedirectToAction("Haftalik", new { hafta = sonHafta });
        }

        public IActionResult Haftalik(int hafta)
        {
            var puanDurumu = _context.PuanDurumu
                                     .Where(p => p.Hafta == hafta)
                                     .OrderByDescending(p => p.P) // Puana göre sırala
                                     .ThenByDescending(p => p.AV) // Averaja göre sırala
                                     .ToList();
            ViewBag.Hafta = hafta; // Hangi haftayı görüntülediğimizi belirtmek için
            return View("Index", puanDurumu);
        }
    }
}
