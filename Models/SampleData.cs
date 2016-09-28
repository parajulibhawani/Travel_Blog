using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelBlog.Models
{
    public class SampleData
    {
        private static TravelBlogDbContext _context;
        public SampleData (TravelBlogDbContext context)
        {
            _context = context;
        }
    }
}
