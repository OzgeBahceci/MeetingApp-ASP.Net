using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        // public IActionResult Apply(String Name, String Phone, String Email,bool WillAttend)
        // Console.WriteLine(Name, Phone, Email, WillAttend);

        public IActionResult Apply(UserInfo userInfo)
        {

            //oluşturulan model yani userInfo
            //bütün aşaöalardan geçiyorsa; örneğin required olan yerler doluysa
            //sorunsuzca oluştuğu durumda isvalid true olur
            if (ModelState.IsValid)
            {
                //Alınan user, user listesine eklendi
                Repository.CreatedUser(userInfo);


                //WillAttend değeri true olan user sayısı
                ViewBag.UserCount = Repository.Users.Where(x => x.WillAttend == true).Count();

                //User alındıktan sonra Thanks viewine yönlerdir ama
                //bir model olmadan yönlendirilmesin userInfo ile cağrılsın
                return View("Thanks", userInfo);
            }

            //eğer hatalı required varsa daha önceden girilen bilgiler sayfaya geri gelsin
            else
            {
                return View(userInfo);
            }
        }
        public IActionResult List()
        {
            return View(Repository.Users);
        }

        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }
    }
}
