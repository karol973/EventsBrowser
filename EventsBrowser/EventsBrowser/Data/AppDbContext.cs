using EventsBrowser.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsBrowser.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist_Event>().HasKey(ae => new
            {
                ae.ArtistId,
                ae.EventId
            });
            modelBuilder.Entity<Artist_Event>().HasOne(e => e.Event).WithMany(ae => ae.Artists_Events).HasForeignKey(e => e.EventId);
            modelBuilder.Entity<Artist_Event>().HasOne(e => e.Artist).WithMany(ae => ae.Artists_Events).HasForeignKey(e => e.ArtistId);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Artist_Event> Artists_Events { get; set; }
        public DbSet<EventPlace> EventPlaces { get; set; }

    }
}
