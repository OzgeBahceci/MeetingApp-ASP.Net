using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            //int saat = 9;
            int saat = DateTime.Now.Hour;
            ViewBag.Selamlama = saat>12 ? "İyi günler":"Günaydın";
            ViewBag.UserName = "Özgiş";
            return View();
        }


    }
}