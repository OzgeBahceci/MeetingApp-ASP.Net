using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(String Name, String Phone, String Email,bool WillAttend)
        {
            Console.WriteLine(Name, Phone, Email, WillAttend);
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
    }
}
