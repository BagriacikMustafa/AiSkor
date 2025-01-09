namespace AiSkor.Models
{
    public class ModelInput
    {
        public string Ev_Sahibi { get; set; }
        public string Deplasman { get; set; }
        public float Ev_Sakat { get; set; }
        public float Deplasman_Sakat { get; set; }
        public float Ev_Cezali { get; set; }
        public float Deplasman_Cezali { get; set; }
        public string Sonuc { get; set; } // 'Sonuc' sütunu
    }
}
