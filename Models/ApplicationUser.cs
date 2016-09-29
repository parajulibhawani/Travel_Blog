using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelBlog.Models
{
    public class ApplicationUser : IdentityUser
    {
        public bool MailingList { get; set; }
    }
}
