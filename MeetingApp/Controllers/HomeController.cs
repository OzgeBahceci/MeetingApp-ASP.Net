using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            var selamla = saat>12 ? "İyi günler":"Günaydın";
            return View(model:selamla);
        }


    }
}