using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using TH_2080600752_NguyenNguyenTrung.Models;
using TH_2080600752_NguyenNguyenTrung.ViewModels;

namespace TH_2080600752_NguyenNguyenTrung.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbcontext;
        public HomeController() 
        {
            _dbcontext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var upcommingCourse = _dbcontext.Courses
                .Include(c => c.Lecture)
                .Include(c => c.Category)
                .Where(c => c.DateTime > DateTime.Now);

            var viewModel = new CoursesViewModel
            {
                UpcomingCourse = upcommingCourse,
                ShowAction = User.Identity.IsAuthenticated
            };
            return View(viewModel);
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