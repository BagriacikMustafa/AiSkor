using AiSkor.Models.Context;
using AiSkor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Security.Cryptography;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace AiSkor.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IPasswordHasher<User> _passwordHasher;

        public AccountController(AppDbContext context, IPasswordHasher<User> passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
        }

        // Register GET Action - Kayıt formunu gösterir
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // Register POST Action - Kullanıcı bilgilerini kaydeder
        [HttpPost]
        public IActionResult Register(User model)
        {
            // Şifreyi hashle
            model.PasswordHash = _passwordHasher.HashPassword(model, model.PasswordHash);
            _context.Users.Add(model);
            _context.SaveChanges();

            TempData["SuccessMessage"] = "Kayıt başarılı! Giriş yapabilirsiniz.";
            return RedirectToAction("Login", "Account");
        }

        // Login GET Action - Giriş formunu gösterir
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string usernameOrEmail, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == usernameOrEmail || u.Email == usernameOrEmail);

            if (user != null)
            {
                // Giriş başarılı ise
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Username)
                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);

                // Kimlik doğrulama işlemi
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                TempData["SuccessMessage"] = "Giriş başarılı!";
                return RedirectToAction("Index", "Home"); // Giriş sonrası yönlendirme
            }

            TempData["ErrorMessage"] = "Geçersiz kullanıcı adı/e-posta veya şifre.";
            return View();
        }

        // Şifremi Unuttum GET - Kullanıcıya şifre sıfırlama formu gösterir
        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        // Şifremi Unuttum POST - E-posta adresi ile şifre sıfırlama talebi
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email);
            if (user != null)
            {
                // Şifre sıfırlama linki oluşturma ve gönderme
                string resetToken = GenerateResetToken();
                string resetLink = Url.Action("ResetPassword", "Account", new { token = resetToken }, Request.Scheme);

                // Şifre sıfırlama linkini e-posta ile gönderme
                await SendPasswordResetEmail(email, resetLink);

                TempData["SuccessMessage"] = "E-posta adresinize bir şifre sıfırlama bağlantısı gönderildi.";
                return RedirectToAction("Login", "Account");
            }

            TempData["ErrorMessage"] = "Bu e-posta adresine kayıtlı bir kullanıcı bulunamadı.";
            return View();
        }

        // Şifre sıfırlama için token üretme (örnek olarak basit bir hash fonksiyonu kullanılabilir)
        private string GenerateResetToken()
        {
            using var sha256 = SHA256.Create();
            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Guid.NewGuid().ToString()));
            return Convert.ToBase64String(bytes);
        }

        // Şifre sıfırlama işlemi - GET
        [HttpGet]
        public IActionResult ResetPassword(string token)
        {
            if (string.IsNullOrEmpty(token))
            {
                return RedirectToAction("Login", "Account");
            }

            return View();
        }

        // Şifre sıfırlama işlemi - POST
        [HttpPost]
        public IActionResult ResetPassword(string token, string newPassword)
        {
            if (string.IsNullOrEmpty(newPassword))
            {
                TempData["ErrorMessage"] = "Yeni şifre girmeniz gerekmektedir.";
                return View();
            }

            var user = _context.Users.FirstOrDefault(u => u.PasswordHash == token); // Token ile eşleştirme
            if (user != null)
            {
                user.PasswordHash = _passwordHasher.HashPassword(user, newPassword);
                _context.SaveChanges();

                TempData["SuccessMessage"] = "Şifreniz başarıyla sıfırlandı!";
                return RedirectToAction("Login", "Account");
            }

            TempData["ErrorMessage"] = "Geçersiz şifre sıfırlama talebi.";
            return View();
        }

        // Şifre sıfırlama e-posta gönderme fonksiyonu (gerçek uygulamada burada bir SMTP servisi kullanılabilir)
        private async Task SendPasswordResetEmail(string email, string resetLink)
        {
            // Gerçek uygulamada SMTP ile e-posta gönderilebilir.
            // Bu örnekte sadece bir mesaj çıktısı olacak.
            Console.WriteLine($"E-posta gönderildi: {email}");
            Console.WriteLine($"Şifre sıfırlama bağlantısı: {resetLink}");
            await Task.CompletedTask;
        }
    }
}
