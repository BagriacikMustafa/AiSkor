using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AiSkor.Models // Projenizin namespace'ine göre düzenleyin
{
    [Table("Galatasaray", Schema = "dbo")] // Tablo adı ve şeması
    public class Galatasaray
    {
        public Galatasaray(string futbolcu)
        {
            Futbolcu = futbolcu;
        }

        [Key] // Primary Key
        [Column("no", TypeName = "int")] // Sütun adı ve veri tipi
        public int No { get; set; } // Forma Numarası

        [Required] // Zorunlu alan
        [Column("mevki", TypeName = "nvarchar(50)")] // Sütun adı ve veri tipi
        public string Mevki { get; set; } // Mevki (Ör: OS, DF)

        [Required] // Zorunlu alan
        [Column("uyruk", TypeName = "nvarchar(50)")] // Sütun adı ve veri tipi
        public string Uyruk { get; set; } // Uyruk (Ülke adı)

        [Required] // Zorunlu alan
        [Column("futbolcu", TypeName = "nvarchar(100)")] // Sütun adı ve veri tipi
        public string Futbolcu { get; set; } // Futbolcu Adı
    }
}
