using AiSkor.Models;
using AiSkor.Models.Context;
using AiSkor.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AiSkor.Controllers
{
    //public class GalatasarayController : Controller
    //{
    //    private readonly AppDbContext _context;

        //public GalatasarayController(AppDbContext context)
        //{
        //    _context = context;
        //}

    //    public IActionResult Index()
    //    {
    //        var galatasarayKadro = _context.Galatasaray.ToList();
    //        var fiksturListesi = _context.Fiksturlar
    //            .Where(f => f.EvSahibi.ToUpper().Contains("GALATASARAY") || f.Deplasman.ToUpper().Contains("GALATASARAY"))
    //            .ToList();

    //        var viewModel = new GalatasarayViewModel
    //        {
    //            Kadro = galatasarayKadro,
    //            Fikstur = fiksturListesi
    //        };

    //        return View(viewModel);
    //    }
    //}

    public class BesiktasController : Controller
    {
        private readonly AppDbContext _context;

        public BesiktasController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var besiktasKadro = _context.Besiktas.ToList();
            var fiksturListesi = _context.Fiksturlar
                .Where(f => f.EvSahibi.ToUpper().Contains("BEŞİKTAŞ A.Ş.") || f.Deplasman.ToUpper().Contains("BEŞİKTAŞ A.Ş."))
                .ToList();

            var viewModel = new BesiktasViewModel
            {
                Kadro = besiktasKadro,
                Fikstur = fiksturListesi
            };

            return View(viewModel);
        }
    }

    public class FenerbahceController : Controller
    {
        private readonly AppDbContext _context;

        public FenerbahceController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
         {
            var fenerbahceKadro = _context.Fenerbahce.ToList();
            var fiksturListesi = _context.Fiksturlar
                .Where(f => f.EvSahibi.ToUpper().Contains("FENERBAHÇE A.Ş.") || f.Deplasman.ToUpper().Contains("FENERBAHÇE A.Ş."))
                .ToList();

            var viewModel = new FenerbahceViewModel
            {
                Kadro = fenerbahceKadro,
                Fikstur = fiksturListesi
            };

            return View(viewModel);
        }
    }

    public class TrabzonsporController : Controller
    {
        private readonly AppDbContext _context;

        public TrabzonsporController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var trabzonsporKadro = _context.Trabzonspor.ToList();
            var fiksturListesi = _context.Fiksturlar
                .Where(f => f.EvSahibi.ToUpper().Contains("TRABZONSPOR") || f.Deplasman.ToUpper().Contains("TRABZONSPOR"))
                .ToList();

            var viewModel = new TrabzonsporViewModel
            {
                Kadro = trabzonsporKadro,
                Fikstur = fiksturListesi
            };

            return View(viewModel);
        }
    }

    public class AntalyasporController : Controller
    {
        private readonly AppDbContext _context;

        public AntalyasporController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var antalyasporKadro = _context.Antalyaspor.ToList();
            var fiksturListesi = _context.Fiksturlar
                .Where(f => f.EvSahibi.ToUpper().Contains("ANTALYASPOR A.Ş.")
                     || f.Deplasman.ToUpper().Contains("ANTALYASPOR A.Ş.")
                     || f.EvSahibi.ToUpper().Contains("ONVO ANTALYASPOR")
                     || f.Deplasman.ToUpper().Contains("ONVO ANTALYASPOR"))
            .ToList();

            var viewModel = new AntalyasporViewModel
            {
                Kadro = antalyasporKadro,
                Fikstur = fiksturListesi
            };

            return View(viewModel);
        }
    }

    public class GaziantepController : Controller
    {
        private readonly AppDbContext _context;

        public GaziantepController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var GaziantepFK = _context.GaziantepFK.ToList();
            var fiksturListesi = _context.Fiksturlar
                .Where(f => f.EvSahibi.ToUpper().Contains("GAZİANTEP FUTBOL KULÜBÜ A.Ş.") || f.Deplasman.ToUpper().Contains("GAZİANTEP FUTBOL KULÜBÜ A.Ş."))
                .ToList();

            var viewModel = new GaziantepViewModel
            {
                Kadro = GaziantepFK,
                Fikstur = fiksturListesi
            };

            return View(viewModel);
        }
    }

    public class KonyasporController : Controller
    {
        private readonly AppDbContext _context;

        public KonyasporController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var konyasporKadro = _context.Konyaspor.ToList();
            var fiksturListesi = _context.Fiksturlar
                .Where(f => f.EvSahibi.ToUpper().Contains("TÜMOSAN KONYASPOR") || f.Deplasman.ToUpper().Contains("TÜMOSAN KONYASPOR"))
                .ToList();

            var viewModel = new KonyasporViewModel
            {
                Kadro = konyasporKadro,
                Fikstur = fiksturListesi
            };

            return View(viewModel);
        }
    }

    public class SivassporController : Controller
    {
        private readonly AppDbContext _context;

        public SivassporController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var sivassporKadro = _context.Sivasspor.ToList();
            var fiksturListesi = _context.Fiksturlar
                .Where(f => f.EvSahibi.ToUpper().Contains("NET GLOBAL SİVASSPOR") || f.Deplasman.ToUpper().Contains("NET GLOBAL SİVASSPOR"))
                .ToList();

            var viewModel = new SivassporViewModel
            {
                Kadro = sivassporKadro,
                Fikstur = fiksturListesi
            };

            return View(viewModel);
        }
    }

    public class HataysporController : Controller
    {
        private readonly AppDbContext _context;

        public HataysporController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var hataysporKadro = _context.Hatayspor.ToList();
            var fiksturListesi = _context.Fiksturlar
                .Where(f => f.EvSahibi.ToUpper().Contains("HATAYSPOR") || f.Deplasman.ToUpper().Contains("HATAYSPOR"))
                .ToList();

            var viewModel = new HataysporViewModel
            {
                Kadro = hataysporKadro,
                Fikstur = fiksturListesi
            };

            return View(viewModel);
        }
    }

    public class AdanaDemirsporController : Controller
    {
        private readonly AppDbContext _context;

        public AdanaDemirsporController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var adanaDemirsporKadro = _context.Adana_Demirspor.ToList();
            var fiksturListesi = _context.Fiksturlar
                .Where(f => f.EvSahibi.ToUpper().Contains("ADANA DEMİRSPOR A.Ş.") || f.Deplasman.ToUpper().Contains("ADANA DEMİRSPOR A.Ş."))
                .ToList();

            var viewModel = new AdanaDemirsporViewModel
            {
                Kadro = adanaDemirsporKadro,
                Fikstur = fiksturListesi
            };

            return View(viewModel);
        }
    }
    // Alanyaspor Controller
    public class AlanyasporController : Controller
    {
        private readonly AppDbContext _context;

        public AlanyasporController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var alanyasporKadro = _context.Alanyaspor.ToList();
            var fiksturListesi = _context.Fiksturlar
                .Where(f => f.EvSahibi.ToUpper().Contains("ALANYASPOR") || f.Deplasman.ToUpper().Contains("ALANYASPOR"))
                .ToList();

            var viewModel = new AlanyasporViewModel
            {
                Kadro = alanyasporKadro,
                Fikstur = fiksturListesi
            };

            return View(viewModel);
        }
    }

    // Basaksehirspor Controller
    public class BasaksehirsporController : Controller
    {
        private readonly AppDbContext _context;

        public BasaksehirsporController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var basaksehirsporKadro = _context.Basaksehispor.ToList();
            var fiksturListesi = _context.Fiksturlar
                .Where(f => f.EvSahibi.ToUpper().Contains("RAMS BAŞAKŞEHİR FUTBOL KULÜBÜ") || f.Deplasman.ToUpper().Contains("RAMS BAŞAKŞEHİR FUTBOL KULÜBÜ"))
                .ToList();

            var viewModel = new BasaksehirsporViewModel
            {
                Kadro = basaksehirsporKadro,
                Fikstur = fiksturListesi
            };

            return View(viewModel);
        }
    }

    // BodrumFK Controller
    public class BodrumFKController : Controller
    {
        private readonly AppDbContext _context;

        public BodrumFKController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var bodrumFKKadro = _context.BodrumFK.ToList();
            var fiksturListesi = _context.Fiksturlar
                .Where(f => f.EvSahibi.ToUpper().Contains("SİPAY BODRUM FK") || f.Deplasman.ToUpper().Contains("SİPAY BODRUM FK"))
                .ToList();

            var viewModel = new BodrumFKViewModel
            {
                Kadro = bodrumFKKadro,
                Fikstur = fiksturListesi
            };

            return View(viewModel);
        }
    }

    // Caykur_Rizespor Controller
    public class CaykurRizesporController : Controller
    {
        private readonly AppDbContext _context;

        public CaykurRizesporController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var caykurRizesporKadro = _context.Caykur_Rizespor.ToList();
            var fiksturListesi = _context.Fiksturlar
                .Where(f => f.EvSahibi.ToUpper().Contains("ÇAYKUR RİZESPOR A.Ş.") || f.Deplasman.ToUpper().Contains("ÇAYKUR RİZESPOR A.Ş."))
                .ToList();

            var viewModel = new RizesporViewModel
            {
                Kadro = caykurRizesporKadro,
                Fikstur = fiksturListesi
            };

            return View(viewModel);
        }
    }

    // Eyupspor Controller
    public class EyupsporController : Controller
    {
        private readonly AppDbContext _context;

        public EyupsporController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var eyupsporKadro = _context.Eyupspor.ToList();
            var fiksturListesi = _context.Fiksturlar
                .Where(f => f.EvSahibi.ToUpper().Contains("EYÜPSPOR") || f.Deplasman.ToUpper().Contains("EYÜPSPOR"))
                .ToList();

            var viewModel = new EyupsporViewModel
            {
                Kadro = eyupsporKadro,
                Fikstur = fiksturListesi
            };

            return View(viewModel);
        }
    }
    // Goztepe Controller
    public class GoztepeController : Controller
    {
        private readonly AppDbContext _context;

        public GoztepeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var goztepeKadro = _context.Goztepe.ToList();
            var fiksturListesi = _context.Fiksturlar
                .Where(f => f.EvSahibi.ToUpper().Contains("GÖZTEPE A.Ş.") || f.Deplasman.ToUpper().Contains("GÖZTEPE A.Ş."))
                .ToList();

            var viewModel = new GoztepeViewModel
            {
                Kadro = goztepeKadro,
                Fikstur = fiksturListesi
            };

            return View(viewModel);
        }
    }

    // Kasimpasa Controller
    public class KasimpasaController : Controller
    {
        private readonly AppDbContext _context;

        public KasimpasaController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var kasimpasaKadro = _context.Kasimpasa.ToList();
            var fiksturListesi = _context.Fiksturlar
                .Where(f => f.EvSahibi.ToUpper().Contains("KASIMPAŞA A.Ş.") || f.Deplasman.ToUpper().Contains("KASIMPAŞA A.Ş."))
                .ToList();

            var viewModel = new KasimpasaViewModel
            {
                Kadro = kasimpasaKadro,
                Fikstur = fiksturListesi
            };

            return View(viewModel);
        }
    }

    // Kayserispor Controller
    public class KayserisporController : Controller
    {
        private readonly AppDbContext _context;

        public KayserisporController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var kayserisporKadro = _context.Kayserispor.ToList();
            var fiksturListesi = _context.Fiksturlar
                .Where(f => f.EvSahibi.ToUpper().Contains("BELLONA KAYSERİSPOR") || f.Deplasman.ToUpper().Contains("BELLONA KAYSERİSPOR"))
                .ToList();

            var viewModel = new KayserisporViewModel
            {
                Kadro = kayserisporKadro,
                Fikstur = fiksturListesi
            };

            return View(viewModel);
        }
    }

    // Samsunspor Controller
    public class SamsunsporController : Controller
    {
        private readonly AppDbContext _context;

        public SamsunsporController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var samsunsporKadro = _context.Samsunspor.ToList();

            var fiksturListesi = _context.Fiksturlar
                .Where(f => f.EvSahibi.ToUpper().Contains("SAMSUNSPOR A.Ş.")
                         || f.Deplasman.ToUpper().Contains("SAMSUNSPOR A.Ş.")
                         || f.EvSahibi.ToUpper().Contains("REEDER SAMSUNSPOR")
                         || f.Deplasman.ToUpper().Contains("REEDER SAMSUNSPOR"))
                .ToList();

            var viewModel = new SamsunsporViewModel
            {
                Kadro = samsunsporKadro,
                Fikstur = fiksturListesi
            };

            return View(viewModel);
        }

    }


}
