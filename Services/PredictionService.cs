using AiSkor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.ML;

namespace AiSkor.PredictionService
{
    public interface IPredictionService
    {
        string Predict(ModelInput input);
    }

    public class PredictionService : IPredictionService
    {
        private readonly ITransformer _model;
        private readonly MLContext _mlContext;

        public PredictionService(string modelPath)
        {
            _mlContext = new MLContext();
            _model = _mlContext.Model.Load(modelPath, out _);
        }

        public string Predict(ModelInput input)
        {
            var predictionEngine = _mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(_model);
            var prediction = predictionEngine.Predict(input);
            return prediction.PredictedLabel;
        }
    }
}
