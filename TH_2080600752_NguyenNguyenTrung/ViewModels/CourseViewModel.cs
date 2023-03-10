using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TH_2080600752_NguyenNguyenTrung.Models;

namespace TH_2080600752_NguyenNguyenTrung.ViewModels
{
    public class CourseViewModel
    {
        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDate() 
        { 
            return DateTime.Parse(string.Format("{0} {1}", Date, Time)); 
        }
    }
}