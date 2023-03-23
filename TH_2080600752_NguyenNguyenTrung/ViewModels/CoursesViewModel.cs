using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TH_2080600752_NguyenNguyenTrung.Models;

namespace TH_2080600752_NguyenNguyenTrung.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcomingCourse { get; set; }
        public bool ShowAction { get; set; }
    }
}