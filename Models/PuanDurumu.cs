using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AiSkor.Models
{
    [Table("PuanDurumu", Schema = "dbo")] // Veritabanı tablosunu belirtir
    public class PuanDurumu
    {
        [Key]
        public int id { get; set; } // Benzersiz ID

        [Required]
        [StringLength(100)]
        public string TakimAdi { get; set; } // Takım adı

        public int O { get; set; } // Oynadığı maç sayısı

        public int G { get; set; } // Galibiyet sayısı

        public int B { get; set; } // Beraberlik sayısı

        public int M { get; set; } // Mağlubiyet sayısı

        public int A { get; set; } // Attığı gol

        public int Y { get; set; } // Yediği gol

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int AV { get; set; } // Averaj

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int P { get; set; } // Puan

        public int Hafta { get; set; } // Haftayı belirten sütun
    }
}
