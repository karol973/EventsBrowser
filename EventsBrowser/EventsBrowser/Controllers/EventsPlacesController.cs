using EventsBrowser.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsBrowser.Controllers
{
    public class EventsPlacesController : Controller
    {
        private readonly AppDbContext _context; // wysyłanie lub odbieranie danych z bazy
        public EventsPlacesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allEventsPlaces = await _context.EventPlaces.ToListAsync();
            return View(allEventsPlaces);
        }
    }
}
