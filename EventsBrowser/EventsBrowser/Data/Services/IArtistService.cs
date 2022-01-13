using EventsBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventsBrowser.Models;

namespace EventsBrowser.Data.Services
{
     public interface IArtistsService
    {
        Task<IEnumerable<Artist>> GetAllAsync();
        Task<Artist> GetByIdAsync(int id);
        Task AddAsync(Artist artist);
        Task<Artist> UpdateAsync(int id, Artist newArtist);

        Task DeleteAsync(int id);
    }
}
