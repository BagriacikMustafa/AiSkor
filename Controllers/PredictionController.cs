using AiSkor.Models;
using AiSkor.PredictionService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AiSkor.Controllers
{
    public class PredictionController : Controller
    {
        private readonly IPredictionService _predictionService;

        // DI kullanarak PredictionService'in controller'a enjekte edilmesi
        public PredictionController(IPredictionService predictionService)
        {
            _predictionService = predictionService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Predict(ModelInput input)
        {
            if (ModelState.IsValid)
            {
                var prediction = _predictionService.Predict(input);
                ViewBag.PredictedLabel = prediction;
            }

            return View("Index");
        }
    }
}
