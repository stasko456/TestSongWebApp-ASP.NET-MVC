using Microsoft.EntityFrameworkCore;
using SongsWebApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsWebApp.DataAccess
{
    public class SongsWebAppContext: DbContext
    {
        public SongsWebAppContext(DbContextOptions<SongsWebAppContext> options): base(options)
        {

        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<ArtistSong> ArtistsSongs { get; set; }
        public DbSet<ArtistAlbum> ArtistsAlbums { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
