using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TH_2080600752_NguyenNguyenTrung.Models;
using TH_2080600752_NguyenNguyenTrung.ViewModels;

namespace TH_2080600752_NguyenNguyenTrung.Controllers
{
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        // GET: Course
        public CourseController()
            {
            _dbContext = new ApplicationDbContext();
            }

        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
    }
}