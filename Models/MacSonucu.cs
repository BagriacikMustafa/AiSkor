using System;
using System.ComponentModel.DataAnnotations.Schema;

[Table("mac_sonuclari")] // Veritabanındaki tablo adı
public class MacSonucu
{
    public int Id { get; set; }
    public string Takim1 { get; set; }
    public string Takim2 { get; set; }
    public int Skor1 { get; set; }
    public int Skor2 { get; set; }
    public string Lig { get; set; }
    public DateTime Tarih { get; set; }

    [Column("ilk_yari_skoru")] // Veritabanındaki sütun adı
    public string IlkYariSkoru { get; set; }

    [Column("saat")] // Veritabanındaki saat sütunu
    public TimeSpan Saat { get; set; } // TimeSpan olarak tanımlayın
}
