using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TravelBlog.Models
{
    [Table("Experiences")]
    public class Experience
    {
        [Key]
        public int ExperienceId { get; set; }
        public string Entry { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<Person> People { get; set; }
        public virtual Location Location { get; set; }
    }
}
