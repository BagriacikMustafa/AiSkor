using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AiSkor.Models // Projenizin namespace'ine göre düzenleyin
{
    [Table("Maclar", Schema = "dbo")] // Veritabanı tablosunu belirtir
    public class Fikstur
    {
        public Fikstur(string evSahibi)
        {
            EvSahibi = evSahibi;
        }

        [Key] // Primary Key
        [Column("id")] // Veritabanındaki sütun adı
        public int Id { get; set; } // Maç ID

        [Column("hafta")] // Veritabanındaki sütun adı
        public int Hafta { get; set; } // Hafta Numarası

        [Required]
        [Column("ev_sahibi")] // Veritabanındaki sütun adı
        public string EvSahibi { get; set; } // Ev sahibi takım

        [Column("ev_skor")] // Veritabanındaki sütun adı
        public int? EvSkor { get; set; } // Ev sahibi skor (nullable)

        [Column("deplasman_skor")] // Veritabanındaki sütun adı
        public int? DeplasmanSkor { get; set; } // Deplasman skor (nullable)

        [Required]
        [Column("deplasman")] // Veritabanındaki sütun adı
        public string Deplasman { get; set; } // Deplasman takımı
    }
}
