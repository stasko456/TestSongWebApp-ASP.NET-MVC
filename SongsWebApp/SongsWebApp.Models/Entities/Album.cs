using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsWebApp.Models.Entities
{
    public class Album
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Album's Title")]
        [StringLength(100, MinimumLength = 1)]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Album's Release Date")]
        public DateOnly ReleaseDate { get; set; }

        [Required]
        [Range(1,1000)]
        [Display(Name = "Album's Length")]
        public double Length { get; set; }

        public ICollection<Song> Songs { get; set; } = new List<Song>();

        public ICollection<ArtistAlbum> ArtistAlbum { get; set; } = new List<ArtistAlbum>();
    }
}
