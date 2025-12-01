using Microsoft.AspNetCore.Mvc;
using SongsWebApp.Core.Servicies.IServicies;
using SongsWebApp.Models.Entities;
using System.Runtime.CompilerServices;

namespace SongsWebApp.Controllers
{
    public class SongController : Controller
    {
        private readonly ISongService _songService;

        public SongController(ISongService songService)
        {
            this._songService = songService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var songs = await _songService.GetAllAsync();
            return View(songs);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Song song)
        {
            if (!ModelState.IsValid)
            {
                return View(song);
            }

            await _songService.CreateAsync(song);
            await _songService.UpdateAsync(song);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<ActionResult> Edit(Guid? id)
        {
            if (id == null || id == Guid.Empty)
            {
                return NotFound();
            }
            var song = await _songService.GetByIdAsync(id);
            if (song == null)
            {
                return NotFound();
            }
            return View(song);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Song song)
        {
            if (!ModelState.IsValid)
            {
                return View(song);
            }
            await _songService.UpdateAsync(song);
            await _songService.DeleteAsync(song);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == null || id == Guid.Empty)
            {
                return NotFound();
            }
            var song = await _songService.GetByIdAsync(id);
            if(song == null)
            {
                return NotFound();
            }

            await _songService.DeleteAsync(song);
            await _songService.SaveAsync();
            return RedirectToAction("Index");
        }
    }
}