using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using EventsBrowser.Data.Services;
using EventsBrowser.Models;

namespace EventsBrowser.Controllers
{
    public class ArtistsController : Controller
    {
        private readonly IArtistsService _service; // wysyłanie lub odbieranie danych z bazy
        public ArtistsController(IArtistsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }
        // GET/Artist/Create
        public  IActionResult  Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>Create([Bind("FullName,ProfilePictureUrl,Bio")]Artist artist)
        {
            if (!ModelState.IsValid)
            {
                return View(artist);

            }
            await _service.AddAsync(artist);
            return RedirectToAction(nameof(Index));
        }

        //GET/Artist/Details
        public async Task<IActionResult> Details (int id)
        {
            var artistDetails = await _service.GetByIdAsync(id);
            if (artistDetails == null) return View("NotFound");
            return View(artistDetails);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("Id,FullName,ProfilePictureUrl,Bio")] Artist artist)
        {
            if (!ModelState.IsValid)
            {
                return View(artist);

            }
            await _service.UpdateAsync(id,artist);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int id)
        {
            var artistDetails = await _service.GetByIdAsync(id);
            if (artistDetails == null) return View("NotFound");
            return View(artistDetails);

        }
        //GET:Artist/Delete/id

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var artistDetails = await _service.GetByIdAsync(id);
            if (artistDetails == null) return View("NotFound");
            await _service.DeleteAsync(id);
             
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            var artistDetails = await _service.GetByIdAsync(id);
            if (artistDetails == null) return View("NotFound");
            return View(artistDetails);

        }
    }
}
