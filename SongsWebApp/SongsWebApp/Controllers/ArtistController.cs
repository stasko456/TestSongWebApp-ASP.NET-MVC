using Microsoft.AspNetCore.Mvc;
using SongsWebApp.Core.Servicies.IServicies;
using SongsWebApp.Models.Entities;
using System.Security.Cryptography;

namespace SongsWebApp.Controllers
{
    public class ArtistController : Controller
    {
        private readonly IArtistService _artistService;

        public ArtistController(IArtistService artistService)
        {
            this._artistService = artistService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var artists = await _artistService.GetAllAsync();
            return View(artists);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Artist artist)
        {
            if (!ModelState.IsValid)
            {
                return View(artist);
            }

            await _artistService.CreateAsync(artist);
            await _artistService.SaveAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || id == Guid.Empty)
            {
                return NotFound();
            }
            var artist = await _artistService.GetByIdAsync(id);
            if (artist == null)
            {
                return NotFound();
            }
            return View(artist);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Artist artist)
        {
            if (!ModelState.IsValid)
            {
                return View(artist);
            }

            await _artistService.UpdateAsync(artist);
            await _artistService.SaveAsync();
            return RedirectToAction("Index");   
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || id == Guid.Empty)
            {
                return NotFound();
            }
            var artist = await _artistService.GetByIdAsync(id);
            if (artist == null)
            {
                return NotFound();
            }
            await _artistService.DeleteAsync(artist);
            await _artistService.SaveAsync();
            return RedirectToAction("Index");
        }
    }
}