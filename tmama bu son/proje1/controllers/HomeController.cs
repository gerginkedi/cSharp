using Microsoft.AspNetCore.Mvc;

namespace proje1.controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "anasayfa";
        }
        public string About()
        {
            return "hakkimizda";
        }
    }
}
