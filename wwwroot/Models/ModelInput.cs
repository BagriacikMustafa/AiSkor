public class ModelInput
{
    [LoadColumn(0)]
    public string Ev_Sahibi { get; set; }

    [LoadColumn(1)]
    public string Deplasman { get; set; }

    [LoadColumn(2)]
    public float Ev_Sakat { get; set; }

    [LoadColumn(3)]
    public float Deplasman_Sakat { get; set; }

    [LoadColumn(4)]
    public float Ev_Cezali { get; set; }

    [LoadColumn(5)]
    public float Deplasman_Cezali { get; set; }

    // 'Sonuc' sütunu tahmin için giriş verisine eklenmemelidir
    // public string Sonuc { get; set; } 
}
