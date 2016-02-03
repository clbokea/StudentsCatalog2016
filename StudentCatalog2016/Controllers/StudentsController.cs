using StudentCatalog2016.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentCatalog2016.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            return View();
        }

        // Action Methods
        public String Greeting()
        {
            return "Hello World";
        }

        public ActionResult Speak()
        {
            ViewBag.saying = "Hello is just a word";
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Name = student.Name;
                ViewBag.LastName = student.LastName;
                ViewBag.Email = student.Email;
                return View("Thanks"); // Calls the View "Thanks"
            }
            else
            {
                return View(student); // call the same if validation problems
            }
           
        }
    }
}