using ShekilPhotoGallery.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShekilPhotoGallery.Core.Interfaces
{
    public interface IPhotoRepository
    {
        Task<Photo> AddAsync(Photo photo);
        Task<Photo?> GetByIdAsync(int id);
        Task<Photo?> GetByPublicIdAsync(string publicId);
        Task<IEnumerable<Photo>> GetAllAsync();
        Task<IEnumerable<Photo>> GetActivePhotosAsync();
        Task<bool> DeleteAsync(int id);
        Task<bool> UpdateAsync(Photo photo);
    }
}
