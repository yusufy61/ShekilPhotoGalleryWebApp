using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ShekilPhotoGallery.Core.Interfaces
{
    public interface ICloudinaryService
    {
        Task<CloudinaryUploadResult> UploadPhotoasync(IFormFile file);
        Task<bool> DeletePhotoAsync(string publicId);
        string GetPhotoAsync(string publicId);
    }

    public class  CloudinaryUploadResult
    {
        public string PublicId { get; set; } = string.Empty;
        public string url { get; set; } = string.Empty;
        public string SecureUrl { get; set; } = string.Empty;
        public string Format { get; set; } = string.Empty;
        public long FileSize { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string ThumbnailUrl { get; set; } = string.Empty;

    }
}