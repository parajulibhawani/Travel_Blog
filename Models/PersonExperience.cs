using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelBlog.Models
{
    public class PersonExperience
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }

        public int ExperienceId { get; set; }
        public Experience Experience { get; set; }
    }
}
