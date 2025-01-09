using Microsoft.EntityFrameworkCore;

namespace AiSkor.Models.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Fikstur> Fiksturlar { get; set; } // Fikstur modelini DbSet olarak tanımlayın

        public DbSet<PuanDurumu> PuanDurumu { get; set; }
        public DbSet<Galatasaray> Galatasaray { get; set; } // Galatasaray tablosu
        public DbSet<Caykur_Rizespor> Caykur_Rizespor { get; set; } // Çaykur Rizespor tablosu
        public DbSet<Adana_Demirspor> Adana_Demirspor { get; set; } // Galatasaray tablosu
        public DbSet<Alanyaspor> Alanyaspor { get; set; } // Galatasaray tablosu
        public DbSet<Antalyaspor> Antalyaspor { get; set; } // Galatasaray tablosu
        public DbSet<Basaksehispor> Basaksehispor { get; set; } // Galatasaray tablosu
        public DbSet<Besiktas> Besiktas { get; set; } // Galatasaray tablosu
        public DbSet<BodrumFK> BodrumFK { get; set; } // Galatasaray tablosu
        public DbSet<Eyupspor> Eyupspor { get; set; } // Galatasaray tablosu
        public DbSet<Fenerbahce> Fenerbahce { get; set; } // Galatasaray tablosu
        public DbSet<GaziantepFK> GaziantepFK { get; set; } // Galatasaray tablosu
        public DbSet<Goztepe> Goztepe { get; set; } // Galatasaray tablosu
        public DbSet<Hatayspor> Hatayspor { get; set; } // Galatasaray tablosu
        public DbSet<Kasimpasa> Kasimpasa { get; set; } // Galatasaray tablosu
        public DbSet<Kayserispor> Kayserispor { get; set; } // Galatasaray tablosu
        public DbSet<Konyaspor> Konyaspor { get; set; } // Galatasaray tablosu
        public DbSet<Samsunspor> Samsunspor { get; set; } // Galatasaray tablosu
        public DbSet<Sivasspor> Sivasspor { get; set; } // Galatasaray tablosu
        public DbSet<Trabzonspor> Trabzonspor { get; set; } // Galatasaray tablosu

        public DbSet<MacSonucu> MacSonuclari { get; set; }

        public DbSet<User> Users { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fikstur>()
                .ToTable("Maclar", "dbo"); // Fikstur modelini Maclar tablosuyla eşleştir
        }
    }
}
