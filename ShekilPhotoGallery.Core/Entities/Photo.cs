using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShekilPhotoGallery.Core.Entities
{
    public class Photo
    {
        /// <summary>
        /// Fotoğrafın DB üzerinde bulunacak Id değeri
        /// </summary>
        [Key]
        public int Id { get; set; }


        /// <summary>
        /// Fotoğrafın genel tanımlayıcısı (Public ID)
        /// </summary>
        [Required]
        [MaxLength(200)]
        public string PublicId { get; set; } = string.Empty;

        /// <summary>
        /// Fotoğrafın URL'si
        /// </summary>
        [Required]
        [MaxLength(500)]
        public string Url { get; set; } = string.Empty;

        /// <summary>
        /// Güvenli (HTTPS) fotoğraf URL'si
        /// </summary>
        [MaxLength(500)]
        public string? SecureUrl { get; set; }

        /// <summary>
        /// Fotoğrafın orijinal dosya adı
        /// </summary>
        [MaxLength(200)]
        public string? FileName { get; set; }


        /// <summary>
        /// Fotoğrafın formatı (örneğin: "jpg", "png")
        /// </summary>
        [MaxLength(100)]
        public string? Format { get; set; }

        /// <summary>
        /// Fotoğrafın dosya boyutu (byte cinsinden)
        /// </summary>
        public long FileSize { get; set; }

        /// <summary>
        /// Fotoğrafın genişliği (piksel cinsinden)
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Fotoğrafın yüksekliği (piksel cinsinden)
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Fotoğrafın küçük önizleme (thumbnail) URL'si
        /// </summary>
        [MaxLength(500)]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// Fotoğrafın açıklaması
        /// </summary>
        [MaxLength(500)]
        public string? Description { get; set; }

        /// <summary>
        /// Fotoğrafın yüklendiği tarih ve saat
        /// Sabit lokasyon kullanılacağı için DateTime.Now kullanıldı.
        /// Eğer ki Global işlem yapılacaksa DateTime.UtcNow türüne çevrilmelidir.
        /// </summary>
        public DateTime UploadedAt { get; set; } = DateTime.Now;

        /// <summary>
        /// Fotoğrafın aktiflik durumu
        /// </summary>
        public bool IsActivate { get; set; } = true;
    }
}
