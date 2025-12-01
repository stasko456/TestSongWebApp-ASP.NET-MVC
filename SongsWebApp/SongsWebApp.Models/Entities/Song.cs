    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsWebApp.Models.Entities
{
    public class Song
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Song's Title")]
        [StringLength(100, MinimumLength = 1)]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Song's Release Date")]
        public DateOnly ReleaseDate { get; set; }

        [Required]
        [Range(0,100)]
        [Display(Name = "Song's Length")]
        public double Length{ get; set; }

        // can be part of an album or just a single (CAN BE NULL)
        [Display(Name = "Album")]
        [ForeignKey(nameof(Album))]
        public Guid AlbumId { get; set; }
        public Album Album { get; set; }

        public ICollection<ArtistSong> ArtistSongs { get; set; } = new List<ArtistSong>();
    }
}