using EventsBrowser.Models;
 
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsBrowser.Data.Services
{
    public class ArtistsService : IArtistsService
    {
        //aby moc pracowac z baza trzeba stowrzyc kontekst
        private readonly AppDbContext _context; // wysyłanie lub odbieranie danych z bazy
        public ArtistsService(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Artist artist)
        {
            await _context.Artists.AddAsync(artist);
           await _context.SaveChangesAsync();

        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Artists.FirstOrDefaultAsync(n => n.Id == id);
            _context.Artists.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Artist>> GetAllAsync()
        {
            var result = await _context.Artists.ToListAsync();
            return result;
        }

        public async Task<Artist> GetByIdAsync(int id)
        {
            var result = await _context.Artists.FirstOrDefaultAsync(n => n.Id == id);
                return result;
        }

        public async Task<Artist> UpdateAsync(int id, Artist newArtist)
        {
            _context.Update(newArtist) ;
            await _context.SaveChangesAsync();
            return newArtist;
        }
    }
}
