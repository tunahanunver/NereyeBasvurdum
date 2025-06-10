using System.ComponentModel.DataAnnotations;

namespace NereyeBasvurdumProject.Models
{
    public class Basvurularim
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Şirket adı zorunludur")]
        [StringLength(100)]
        public string? Sirket { get; set; }

        [StringLength(100)]
        public string? Lokasyon { get; set; }

        [Required(ErrorMessage = "Pozisyon bilgisi zorunludur")]
        [StringLength(100)]
        public string? Pozisyon { get; set; }

        [StringLength(50)]
        public string? Deneyim { get; set; }

        [StringLength(100)]
        public string? Araci { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Başvuru Tarihi")]
        public DateTime BasvuruTarihi { get; set; }

        [StringLength(50)]
        public string? Durum { get; set; }
    }
}
