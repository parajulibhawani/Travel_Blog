using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
