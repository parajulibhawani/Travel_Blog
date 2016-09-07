using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TravelBlog.Models
{
    [Table("People")]
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }
    }
    private static ICollection<Experience> GetExperiences(Person p)
    {
        return p.Experiences;
    }
}
