using SongsWebApp.Core.Servicies.IServicies;
using SongsWebApp.DataAccess.Repositories.IRepositories;
using SongsWebApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SongsWebApp.Core.Servicies
{
    public class ArtistService : IArtistService
    {
        private readonly IRepository<Artist> _repository;

        public ArtistService(IRepository<Artist> repository)
        {
            this._repository = repository;
        }

        public async Task CreateAsync(Artist artist)
        {
            await _repository.CreateAsync(artist);
        }

        public async Task DeleteAsync(Artist artist)
        {
            await _repository.DeleteAsync(artist);
        }

        public async Task<IEnumerable<Artist>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Artist> GetByIdAsync(Guid? id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task SaveAsync()
        {
            await _repository.SaveAsync();
        }

        public async Task UpdateAsync(Artist artist)
        {
            await _repository.UpdateAsync(artist);
        }
    }
}