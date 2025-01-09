using AiSkor.Models;
using AiSkor.Models.Context;
using AiSkor.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AiSkor.Controllers
{
    public class GalatasarayController : Controller
    {
        private readonly AppDbContext _context;

        public GalatasarayController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Veritabanından Galatasaray kadrosu ve fikstürü için verileri çekiyoruz
            var galatasarayKadro = _context.Galatasaray.ToList(); // Galatasaray tablosundaki futbolcular
            var fiksturListesi = _context.Fiksturlar
                .Where(f => f.EvSahibi.ToUpper().Contains("GALATASARAY") || f.Deplasman.ToUpper().Contains("GALATASARAY"))
                .ToList(); // Sadece Galatasaray'ın olduğu maçlar

            // GalatasarayViewModel nesnesi oluşturuluyor
            var viewModel = new GalatasarayViewModel
            {
                Kadro = galatasarayKadro,
                Fikstur = fiksturListesi
            };

            // View'e model gönderiliyor
            return View(viewModel);
        }
    }
}
