using LabSchool_LeDangAnhQuan.Models;
using System;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;

namespace LabSchool_LeDangAnhQuan.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext;
        public HomeController()
        {
            _dbContext = new ApplicationDbContext();

        }

        public ActionResult Index()
        {
                 var upcommingCourses = _dbContext.Courses
                 .Include(c => c.Lecturer)
                 .Include(c => c.Category)
                 .Where(c => c.Datetime > DateTime.Now);
            return View(upcommingCourses);
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}