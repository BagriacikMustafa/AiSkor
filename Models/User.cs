using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AiSkor.Models
{
    public class User : IdentityUser
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } // İsim

        [Required]
        [StringLength(50)]
        public string LastName { get; set; } // Soyisim

        [Required]
        [StringLength(50)]
        public string Username { get; set; } // Kullanıcı Adı

        [Required]
        [EmailAddress]
        public string Email { get; set; } // E-posta

        [Required]
        [Phone]
        public string PhoneNumber { get; set; } // Telefon Numarası

        [Required]
        [DataType(DataType.Password)]
        public string PasswordHash { get; set; } // Şifre

        [Required]
        [StringLength(10)]
        public string Gender { get; set; } // Cinsiyet (Erkek/Kadın/Diğer)

        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; } // Doğum Tarihi
    }
}
