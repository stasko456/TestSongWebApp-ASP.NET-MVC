using SongsWebApp.Core.Servicies.IServicies;
using SongsWebApp.DataAccess.Repositories.IRepositories;
using SongsWebApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsWebApp.Core.Servicies
{
    public class SongService : ISongService
    {
        private readonly IRepository<Song> _songRepo;

        public SongService(IRepository<Song> songRepo)
        {
            this._songRepo = songRepo;
        }

        public async Task CreateAsync(Song song)
        {
            await _songRepo.CreateAsync(song);
        }

        public async Task DeleteAsync(Song song)
        {
            await _songRepo.DeleteAsync(song);
        }

        public async Task<IEnumerable<Song>> GetAllAsync()
        {
            return await _songRepo.GetAllAsync();
        }

        public async Task<Song> GetByIdAsync(Guid? id)
        {
            return await _songRepo.GetByIdAsync(id);
        }

        public async Task SaveAsync()
        {
            await _songRepo.SaveAsync();
        }

        public async Task UpdateAsync(Song song)
        {
            await _songRepo.UpdateAsync(song);
        }
    }
}