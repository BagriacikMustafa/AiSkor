using AiSkor.Models;
using AiSkor.PredictionService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;



public class AiController : Controller
{
    private readonly IPredictionService _predictionService;

    public AiController(IPredictionService predictionService)
    {
        _predictionService = predictionService;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Predict(string evSahibi, string deplasman, int evSakat, int deplasmanSakat, int evCezali, int deplasmanCezali)
    {
        try
        {
            var input = new ModelInput
            {
                Ev_Sahibi = evSahibi,
                Deplasman = deplasman,
                Ev_Sakat = evSakat,
                Deplasman_Sakat = deplasmanSakat,
                Ev_Cezali = evCezali,
                Deplasman_Cezali = deplasmanCezali
            };

            var prediction = _predictionService.Predict(input);
            ViewBag.Result = prediction; // Changed from prediction.PredictedLabel to prediction
        }
        catch (Exception ex)
        {
            ViewBag.Error = $"Hata oluştu: {ex.Message}";
        }

        return View("Index");
    }
}
