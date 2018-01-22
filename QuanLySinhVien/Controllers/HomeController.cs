using QuanLySinhVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLySinhVien.Controllers
{
    public class HomeController : Controller
    {
        QuanLySinhVienDBContext db = new QuanLySinhVienDBContext();
        public ActionResult Index()
        {
            List<Lop> Lops = (from sv in db.Lops select sv).ToList();
            return View(Lops);
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