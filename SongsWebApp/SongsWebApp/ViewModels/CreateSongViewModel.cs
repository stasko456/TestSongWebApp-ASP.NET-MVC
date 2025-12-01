using Microsoft.AspNetCore.Mvc.Rendering;
using SongsWebApp.Models.Entities;

namespace SongsWebApp.ViewModels
{
    public class CreateSongViewModel
    {
        public int Title { get; set; }

        public DateOnly ReleaseDate { get; set; }

        public double Length { get; set; }

        public int AlbumId { get; set; }

        public List<int> SelectedArtistIds { get; set; } = new();

        public List<SelectListItem> AvailableArtists { get; set; } = new();

        public List<SelectListItem> AvailableAlbums { get; set; } = new();

    }
}
