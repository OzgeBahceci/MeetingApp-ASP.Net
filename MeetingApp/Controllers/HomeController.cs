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

            ////ViewBag
            //ViewBag.Selamlama = saat>12 ? "İyi günler":"Günaydın";
            //ViewBag.UserName = "Özgiş";

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "Istanbul, Büyük Kongre Merkezi",
                Date = new DateTime(2024, 01,20,20,0,0),
                NumberOfPeople = 100

            };

            //ViewData
            ViewData["Selamlama"] = saat > 12 ? "İyi günler" : "Günaydın";
            ViewData["UserName"] = "Özgiş";


            return View(meetingInfo);
        }


    }
}