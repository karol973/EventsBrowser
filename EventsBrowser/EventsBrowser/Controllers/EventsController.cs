using EventsBrowser.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsBrowser.Controllers
{
         
        public class EventsController : Controller
    {
        private readonly AppDbContext _context; // wysyłanie lub odbieranie danych z bazy
        public EventsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allEvents = await _context.Events.Include(m => m.EventPlace).ToListAsync();
            return View(allEvents);
        }
    }
}
