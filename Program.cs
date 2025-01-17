using AiSkor.Models;
using AiSkor.Models.Context;
using AiSkor.PredictionService;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages(); // Razor Pages desteği

// Veritabanı bağlantısını ekle
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// PredictionService'i DI container'a ekle
builder.Services.AddScoped<IPredictionService, PredictionService>(provider =>
{
    // Modelin yolu
    var modelPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "models", "futbol_model.zip");
    return new PredictionService(modelPath);
});

// Identity'i ekle
builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders(); // Identity yapılandırmasını ekliyoruz

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // HSTS (HTTP Strict Transport Security) kullanımı
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // wwwroot klasörü gibi statik dosyaları kullan

app.UseRouting();

app.UseAuthentication(); // Kimlik doğrulama middleware'i
app.UseAuthorization(); // Yetkilendirme middleware

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
