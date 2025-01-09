using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AiSkor.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Adana_Demirspor",
                schema: "dbo",
                columns: table => new
                {
                    no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mevki = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    uyruk = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    futbolcu = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adana_Demirspor", x => x.no);
                });

            migrationBuilder.CreateTable(
                name: "Alanyaspor",
                schema: "dbo",
                columns: table => new
                {
                    no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mevki = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    uyruk = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    futbolcu = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alanyaspor", x => x.no);
                });

            migrationBuilder.CreateTable(
                name: "Antalyaspor",
                schema: "dbo",
                columns: table => new
                {
                    no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mevki = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    uyruk = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    futbolcu = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Antalyaspor", x => x.no);
                });

            migrationBuilder.CreateTable(
                name: "Basaksehirspor",
                schema: "dbo",
                columns: table => new
                {
                    no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mevki = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    uyruk = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    futbolcu = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Basaksehirspor", x => x.no);
                });

            migrationBuilder.CreateTable(
                name: "Besiktas",
                schema: "dbo",
                columns: table => new
                {
                    no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mevki = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    uyruk = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    futbolcu = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Besiktas", x => x.no);
                });

            migrationBuilder.CreateTable(
                name: "BodrumFK",
                schema: "dbo",
                columns: table => new
                {
                    no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mevki = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    uyruk = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    futbolcu = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodrumFK", x => x.no);
                });

            migrationBuilder.CreateTable(
                name: "Caykur_Rizespor",
                schema: "dbo",
                columns: table => new
                {
                    no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mevki = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    uyruk = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    futbolcu = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caykur_Rizespor", x => x.no);
                });

            migrationBuilder.CreateTable(
                name: "Eyupspor",
                schema: "dbo",
                columns: table => new
                {
                    no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mevki = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    uyruk = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    futbolcu = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eyupspor", x => x.no);
                });

            migrationBuilder.CreateTable(
                name: "Fenerbahce",
                schema: "dbo",
                columns: table => new
                {
                    no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mevki = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    uyruk = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    futbolcu = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fenerbahce", x => x.no);
                });

            migrationBuilder.CreateTable(
                name: "Galatasaray",
                schema: "dbo",
                columns: table => new
                {
                    no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mevki = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    uyruk = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    futbolcu = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galatasaray", x => x.no);
                });

            migrationBuilder.CreateTable(
                name: "GaziantepFK",
                schema: "dbo",
                columns: table => new
                {
                    no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mevki = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    uyruk = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    futbolcu = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GaziantepFK", x => x.no);
                });

            migrationBuilder.CreateTable(
                name: "Goztepe",
                schema: "dbo",
                columns: table => new
                {
                    no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mevki = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    uyruk = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    futbolcu = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goztepe", x => x.no);
                });

            migrationBuilder.CreateTable(
                name: "Hatayspor",
                schema: "dbo",
                columns: table => new
                {
                    no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mevki = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    uyruk = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    futbolcu = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hatayspor", x => x.no);
                });

            migrationBuilder.CreateTable(
                name: "Kasimpasa",
                schema: "dbo",
                columns: table => new
                {
                    no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mevki = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    uyruk = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    futbolcu = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kasimpasa", x => x.no);
                });

            migrationBuilder.CreateTable(
                name: "Kayserispor",
                schema: "dbo",
                columns: table => new
                {
                    no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mevki = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    uyruk = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    futbolcu = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kayserispor", x => x.no);
                });

            migrationBuilder.CreateTable(
                name: "Konyaspor",
                schema: "dbo",
                columns: table => new
                {
                    no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mevki = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    uyruk = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    futbolcu = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Konyaspor", x => x.no);
                });

            migrationBuilder.CreateTable(
                name: "mac_sonuclari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Takim1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Takim2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Skor1 = table.Column<int>(type: "int", nullable: false),
                    Skor2 = table.Column<int>(type: "int", nullable: false),
                    Lig = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ilk_yari_skoru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    saat = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mac_sonuclari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Maclar",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hafta = table.Column<int>(type: "int", nullable: false),
                    ev_sahibi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ev_skor = table.Column<int>(type: "int", nullable: true),
                    deplasman_skor = table.Column<int>(type: "int", nullable: true),
                    deplasman = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maclar", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PuanDurumu",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TakimAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    O = table.Column<int>(type: "int", nullable: false),
                    G = table.Column<int>(type: "int", nullable: false),
                    B = table.Column<int>(type: "int", nullable: false),
                    M = table.Column<int>(type: "int", nullable: false),
                    A = table.Column<int>(type: "int", nullable: false),
                    Y = table.Column<int>(type: "int", nullable: false),
                    AV = table.Column<int>(type: "int", nullable: false),
                    P = table.Column<int>(type: "int", nullable: false),
                    Hafta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuanDurumu", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Samsunspor",
                schema: "dbo",
                columns: table => new
                {
                    no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mevki = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    uyruk = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    futbolcu = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Samsunspor", x => x.no);
                });

            migrationBuilder.CreateTable(
                name: "Sivasspor",
                schema: "dbo",
                columns: table => new
                {
                    no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mevki = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    uyruk = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    futbolcu = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sivasspor", x => x.no);
                });

            migrationBuilder.CreateTable(
                name: "Trabzonspor",
                schema: "dbo",
                columns: table => new
                {
                    no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mevki = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    uyruk = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    futbolcu = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trabzonspor", x => x.no);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adana_Demirspor",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Alanyaspor",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Antalyaspor",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Basaksehirspor",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Besiktas",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "BodrumFK",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Caykur_Rizespor",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Eyupspor",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Fenerbahce",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Galatasaray",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "GaziantepFK",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Goztepe",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Hatayspor",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Kasimpasa",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Kayserispor",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Konyaspor",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "mac_sonuclari");

            migrationBuilder.DropTable(
                name: "Maclar",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PuanDurumu",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Samsunspor",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Sivasspor",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Trabzonspor",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
