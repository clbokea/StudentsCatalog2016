using StudentCatalog2016.Models;
using StudentCatalog2016.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentCatalog2016.Controllers
{
    public class StudentsController : Controller
    {
        // quick and dirty - later dependency injection - this create an dependency which we do not want
        //ApplicationDbContext db = new ApplicationDbContext();

        StudentRepository studentRepo = new StudentRepository();

        // GET: Students
        public ActionResult Index()
        {
            // gets all student from db and converts it to a list
            List<Student> students = db.Students.ToList(); // if model in view is Null this is missing
            return View(students);
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

        // used for exercise
        public ActionResult Edit(int id) {
            // look up a student object from the db by id
            // send student object to the edit view
            // create a edit view ( do that based on the create view)
            // create a post-version of the edit action-method

            Student students = db.Students.Find(id);
            // so no need for "Select * from students where id = id"
            return View(students);
        }
        [HttpPost]
        public ActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                // db.Students.Add(student);
                // db.SaveChanges();
                // for edit not create - do as exercise!
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                //return View("Thanks");
                return RedirectToAction("Index");
            }

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


                // for edit not create - do as exercise!
                // db.Entry(student).State = System.Data.Entity.EntityState.Modified;

                db.Students.Add(student);
                db.SaveChanges();

                return View("Thanks"); // Calls the View "Thanks"
            }
            else
            {
                return View(); // call the same view if validation problem occours
            }
           
        }

    }
}