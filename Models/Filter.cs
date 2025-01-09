using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AiSkor.Models
{

    [Table("Fenerbahce", Schema = "dbo")]
    public class Fenerbahce
    {
        public Fenerbahce(string futbolcu)
        {
            Futbolcu = futbolcu;
        }

        [Key]
        [Column("no", TypeName = "int")]
        public int No { get; set; }

        [Required]
        [Column("mevki", TypeName = "nvarchar(50)")]
        public string Mevki { get; set; }

        [Required]
        [Column("uyruk", TypeName = "nvarchar(50)")]
        public string Uyruk { get; set; }

        [Required]
        [Column("futbolcu", TypeName = "nvarchar(100)")]
        public string Futbolcu { get; set; }
    }



    [Table("Besiktas", Schema = "dbo")]
    public class Besiktas
    {
        public Besiktas(string futbolcu)
        {
            Futbolcu = futbolcu;
        }

        [Key]
        [Column("no", TypeName = "int")]
        public int No { get; set; }

        [Required]
        [Column("mevki", TypeName = "nvarchar(50)")]
        public string Mevki { get; set; }

        [Required]
        [Column("uyruk", TypeName = "nvarchar(50)")]
        public string Uyruk { get; set; }

        [Required]
        [Column("futbolcu", TypeName = "nvarchar(100)")]
        public string Futbolcu { get; set; }
    }

    [Table("Trabzonspor", Schema = "dbo")]
    public class Trabzonspor
    {
        public Trabzonspor(string futbolcu)
        {
            Futbolcu = futbolcu;
        }

        [Key]
        [Column("no", TypeName = "int")]
        public int No { get; set; }

        [Required]
        [Column("mevki", TypeName = "nvarchar(50)")]
        public string Mevki { get; set; }

        [Required]
        [Column("uyruk", TypeName = "nvarchar(50)")]
        public string Uyruk { get; set; }

        [Required]
        [Column("futbolcu", TypeName = "nvarchar(100)")]
        public string Futbolcu { get; set; }
    }

    [Table("Adana_Demirspor", Schema = "dbo")]
    public class Adana_Demirspor
    {

        [Key]
        [Column("no", TypeName = "int")]
        public int No { get; set; }

        [Required]
        [Column("mevki", TypeName = "nvarchar(50)")]
        public string Mevki { get; set; }

        [Required]
        [Column("uyruk", TypeName = "nvarchar(50)")]
        public string Uyruk { get; set; }

        [Required]
        [Column("futbolcu", TypeName = "nvarchar(100)")]
        public string Futbolcu { get; set; }
    }

    [Table("Konyaspor", Schema = "dbo")]
    public class Konyaspor
    {


        [Key]
        [Column("no", TypeName = "int")]
        public int No { get; set; }

        [Required]
        [Column("mevki", TypeName = "nvarchar(50)")]
        public string Mevki { get; set; }

        [Required]
        [Column("uyruk", TypeName = "nvarchar(50)")]
        public string Uyruk { get; set; }

        [Required]
        [Column("futbolcu", TypeName = "nvarchar(100)")]
        public string Futbolcu { get; set; }
    }

    [Table("Gaziantep", Schema = "dbo")]
    public class Gaziantep
    {

        [Key]
        [Column("no", TypeName = "int")]
        public int No { get; set; }

        [Required]
        [Column("mevki", TypeName = "nvarchar(50)")]
        public string Mevki { get; set; }

        [Required]
        [Column("uyruk", TypeName = "nvarchar(50)")]
        public string Uyruk { get; set; }

        [Required]
        [Column("futbolcu", TypeName = "nvarchar(100)")]
        public string Futbolcu { get; set; }
    }

    [Table("Sivasspor", Schema = "dbo")]
    public class Sivasspor
    {

        [Key]
        [Column("no", TypeName = "int")]
        public int No { get; set; }

        [Required]
        [Column("mevki", TypeName = "nvarchar(50)")]
        public string Mevki { get; set; }

        [Required]
        [Column("uyruk", TypeName = "nvarchar(50)")]
        public string Uyruk { get; set; }

        [Required]
        [Column("futbolcu", TypeName = "nvarchar(100)")]
        public string Futbolcu { get; set; }
    }

    [Table("Hatayspor", Schema = "dbo")]
    public class Hatayspor
    {

        [Key]
        [Column("no", TypeName = "int")]
        public int No { get; set; }

        [Required]
        [Column("mevki", TypeName = "nvarchar(50)")]
        public string Mevki { get; set; }

        [Required]
        [Column("uyruk", TypeName = "nvarchar(50)")]
        public string Uyruk { get; set; }

        [Required]
        [Column("futbolcu", TypeName = "nvarchar(100)")]
        public string Futbolcu { get; set; }
    }

    [Table("Antalyaspor", Schema = "dbo")]
    public class Antalyaspor
    {

        [Key]
        [Column("no", TypeName = "int")]
        public int No { get; set; }

        [Required]
        [Column("mevki", TypeName = "nvarchar(50)")]
        public string Mevki { get; set; }

        [Required]
        [Column("uyruk", TypeName = "nvarchar(50)")]
        public string Uyruk { get; set; }

        [Required]
        [Column("futbolcu", TypeName = "nvarchar(100)")]
        public string Futbolcu { get; set; }
    }

    [Table("Alanyaspor", Schema = "dbo")]
    public class Alanyaspor
    {

        [Key]
        [Column("no", TypeName = "int")]
        public int No { get; set; }

        [Required]
        [Column("mevki", TypeName = "nvarchar(50)")]
        public string Mevki { get; set; }

        [Required]
        [Column("uyruk", TypeName = "nvarchar(50)")]
        public string Uyruk { get; set; }

        [Required]
        [Column("futbolcu", TypeName = "nvarchar(100)")]
        public string Futbolcu { get; set; }
    }

    [Table("Basaksehirspor", Schema = "dbo")]
    public class Basaksehispor
    {

        [Key]
        [Column("no", TypeName = "int")]
        public int No { get; set; }

        [Required]
        [Column("mevki", TypeName = "nvarchar(50)")]
        public string Mevki { get; set; }

        [Required]
        [Column("uyruk", TypeName = "nvarchar(50)")]
        public string Uyruk { get; set; }

        [Required]
        [Column("futbolcu", TypeName = "nvarchar(100)")]
        public string Futbolcu { get; set; }
    }

    [Table("BodrumFK", Schema = "dbo")]
    public class BodrumFK
    {

        [Key]
        [Column("no", TypeName = "int")]
        public int No { get; set; }

        [Required]
        [Column("mevki", TypeName = "nvarchar(50)")]
        public string Mevki { get; set; }

        [Required]
        [Column("uyruk", TypeName = "nvarchar(50)")]
        public string Uyruk { get; set; }

        [Required]
        [Column("futbolcu", TypeName = "nvarchar(100)")]
        public string Futbolcu { get; set; }
    }

    [Table("Caykur_Rizespor", Schema = "dbo")]
    public class Caykur_Rizespor
    {

        [Key]
        [Column("no", TypeName = "int")]
        public int No { get; set; }

        [Required]
        [Column("mevki", TypeName = "nvarchar(50)")]
        public string Mevki { get; set; }

        [Required]
        [Column("uyruk", TypeName = "nvarchar(50)")]
        public string Uyruk { get; set; }

        [Required]
        [Column("futbolcu", TypeName = "nvarchar(100)")]
        public string Futbolcu { get; set; }
    }


    [Table("Eyupspor", Schema = "dbo")]
    public class Eyupspor
    {

        [Key]
        [Column("no", TypeName = "int")]
        public int No { get; set; }

        [Required]
        [Column("mevki", TypeName = "nvarchar(50)")]
        public string Mevki { get; set; }

        [Required]
        [Column("uyruk", TypeName = "nvarchar(50)")]
        public string Uyruk { get; set; }

        [Required]
        [Column("futbolcu", TypeName = "nvarchar(100)")]
        public string Futbolcu { get; set; }
    }


    [Table("GaziantepFK", Schema = "dbo")]
    public class GaziantepFK
    {

        [Key]
        [Column("no", TypeName = "int")]
        public int No { get; set; }

        [Required]
        [Column("mevki", TypeName = "nvarchar(50)")]
        public string Mevki { get; set; }

        [Required]
        [Column("uyruk", TypeName = "nvarchar(50)")]
        public string Uyruk { get; set; }

        [Required]
        [Column("futbolcu", TypeName = "nvarchar(100)")]
        public string Futbolcu { get; set; }
    }

    [Table("Goztepe", Schema = "dbo")]
    public class Goztepe
    {

        [Key]
        [Column("no", TypeName = "int")]
        public int No { get; set; }

        [Required]
        [Column("mevki", TypeName = "nvarchar(50)")]
        public string Mevki { get; set; }

        [Required]
        [Column("uyruk", TypeName = "nvarchar(50)")]
        public string Uyruk { get; set; }

        [Required]
        [Column("futbolcu", TypeName = "nvarchar(100)")]
        public string Futbolcu { get; set; }
    }

    [Table("Kasimpasa", Schema = "dbo")]
    public class Kasimpasa
    {
        [Key]
        [Column("no", TypeName = "int")]
        public int No { get; set; }

        [Required]
        [Column("mevki", TypeName = "nvarchar(50)")]
        public string Mevki { get; set; }

        [Required]
        [Column("uyruk", TypeName = "nvarchar(50)")]
        public string Uyruk { get; set; }

        [Required]
        [Column("futbolcu", TypeName = "nvarchar(100)")]
        public string Futbolcu { get; set; }
    }

    [Table("Kayserispor", Schema = "dbo")]
    public class Kayserispor
    {
        [Key]
        [Column("no", TypeName = "int")]
        public int No { get; set; }

        [Required]
        [Column("mevki", TypeName = "nvarchar(50)")]
        public string Mevki { get; set; }

        [Required]
        [Column("uyruk", TypeName = "nvarchar(50)")]
        public string Uyruk { get; set; }

        [Required]
        [Column("futbolcu", TypeName = "nvarchar(100)")]
        public string Futbolcu { get; set; }
    }


    [Table("Samsunspor", Schema = "dbo")]
    public class Samsunspor
    {
        [Key]
        [Column("no", TypeName = "int")]
        public int No { get; set; }

        [Required]
        [Column("mevki", TypeName = "nvarchar(50)")]
        public string Mevki { get; set; }

        [Required]
        [Column("uyruk", TypeName = "nvarchar(50)")]
        public string Uyruk { get; set; }

        [Required]
        [Column("futbolcu", TypeName = "nvarchar(100)")]
        public string Futbolcu { get; set; }
    }


}