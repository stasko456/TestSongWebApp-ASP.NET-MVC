using SongsWebApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsWebApp.Core.Servicies.IServicies
{
    public interface IArtistService
    {
        Task<IEnumerable<Artist>> GetAllAsync();
        Task<Artist> GetByIdAsync(Guid? id);
        Task CreateAsync(Artist artist);
        Task UpdateAsync(Artist artist);
        Task DeleteAsync(Artist artist);
        Task SaveAsync();
    }
}
