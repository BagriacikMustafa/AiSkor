using Microsoft.AspNetCore.Mvc;
using AiSkor.Models;
using AiSkor.Models.Context; // Eğer DbContext burada tanımlıysa

namespace AiSkor.Controllers
{
    public class FiksturController : Controller
    {
        private readonly AppDbContext _context;

        public FiksturController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var fiksturListesi = _context.Fiksturlar.ToList(); // Veritabanından tüm fikstürleri al
            return View(fiksturListesi); // Veriyi View'e gönder
        }
    }
}
