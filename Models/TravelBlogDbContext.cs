using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace TravelBlog.Models
{
    public class TravelBlogDBContext : DbContext
    {
        public DbSet<Experience> Categories { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Person> People { get; set; }

        public TravelBlogDBContext(DbContextOptions<TravelBlogDBContext> options)
            : base(options)
        {
        }

        public TravelBlogDBContext() : base()
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PersonLocation>().HasKey(x => new { x.PersonId, x.LocationId });
            /*builder.Entity<PersonLocation>()
                .HasOne(pl => pl.Person)
                .WithMany(p => p.PersonLocations)
                .HasForeignKey(pl => pl.PersonId);

            builder.Entity<PersonLocation>()
                .HasOne(pl => pl.Location)
                .WithMany(l => l.PersonLocations)
                .HasForeignKey(pl => pl.LocationId);*/

        }
    }
}
