using Microsoft.AspNetCore.Mvc;
using MVC_AboutMe.Models;

namespace MVC_AboutMe.Controllers
{
    public class HomeController : Controller
    {
        static AboutModel about = new AboutModel()
        {
            Name = "Ozan Erel",
            Bio = "Merhaba,ben Okan Üniversitesi,Bilişim Sistemleri ve Teknolojileri 4.sınıf öğrencisiyim. Şu an BilgeAdam Akademi'de FullStack programlama öğrencisiyim.",
            Hobbies = new string[] {"Kitap okumak", "Spor yapmak",  "Yeni Teknolojileri Takip Etmek" , "Yeni Şeyler Öğrenmek" }
        };

        public IActionResult Index()
        {

            return View(about);
        }
    }
}
