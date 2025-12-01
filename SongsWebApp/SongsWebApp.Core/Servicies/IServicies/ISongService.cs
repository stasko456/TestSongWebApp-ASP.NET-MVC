using SongsWebApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsWebApp.Core.Servicies.IServicies
{
    public interface ISongService
    {
        Task<IEnumerable<Song>> GetAllAsync();
        Task<Song> GetByIdAsync(Guid? id);
        Task CreateAsync(Song song);
        Task UpdateAsync(Song song);
        Task DeleteAsync(Song song);
        Task SaveAsync();
    }
}
