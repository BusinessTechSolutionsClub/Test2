using School.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School.Controllers
{
    public class StudentHomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: StudentEnrollment
        [Authorize]
        public ActionResult Index()
        {
            // Get userId from the login
            var userId = User.Identity.GetUserId();

            // Find studentId
            var studentId = db.Students.Where(s => s.ApplicationUserId == userId).First().Id;

            // Store in ViewBag
            ViewBag.studentId = studentId;

            return View();
        }
    }
}