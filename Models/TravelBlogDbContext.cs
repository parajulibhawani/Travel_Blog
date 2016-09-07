using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelBlog.Models
{
    public class TravelBlogDbContext : DbContext
    {
        public DbSet<Experience> Categories { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Person> People { get; set; }

        public TravelBlogDbContext(DbContextOptions<TravelBlogDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
