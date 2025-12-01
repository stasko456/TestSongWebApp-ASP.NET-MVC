using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsWebApp.Models.Entities
{
    public class Artist
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Artist's Name")]
        [StringLength(100, MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Artist's Country of Origin")]
        public string CountryOfOrigin { get; set; }

        [Required]
        [Display(Name = "Artist's Debut Year")]
        [Range(1,9999)]
        public int DebutYear { get; set; }

        public ICollection<ArtistAlbum> ArtistAlbum { get; set; } = new List<ArtistAlbum>();

        public ICollection<ArtistSong> ArtistSongs { get; set; } = new List<ArtistSong>();
    }
}