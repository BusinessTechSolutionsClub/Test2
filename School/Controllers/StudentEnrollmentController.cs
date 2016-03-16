using School.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School.Controllers
{
    public class StudentEnrollmentController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: StudentEnrollment
        [Authorize]
        public ActionResult Index()
        {
            // Retreive all available courses
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "Title");

            return View();
        }

        [HttpPost]
        public ActionResult Index(Enrollment enrollment)
        {
            if (ModelState.IsValid)
            {
                db.Enrollments.Add(enrollment);
                db.SaveChanges();
                return RedirectToAction("Index", "StudentHome");
            }

            return View();          
        }
    }
}