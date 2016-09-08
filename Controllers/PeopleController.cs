using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelBlog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TravelBlog.Controllers
{
    public class PeopleController : Controller
    {
        private TravelBlogContext db = new TravelBlogContext();
        public IActionResult Index()
        {
            return View(db.People.ToList());
        }
        public IActionResult Details(int id)
        {
            var thisPerson = db.People.FirstOrDefault(people => people.PersonId == id);
            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "Name");
            return View(thisPerson);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            db.People.Add(person);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Details(int personId, int locationId)
        {
            var personLocations = new PersonLocation(personId, locationId);
            Console.WriteLine(personId);
            Console.WriteLine(locationId);
            db.PersonLocation.Add(personLocations);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
