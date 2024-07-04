using Microsoft.AspNetCore.Mvc;
using System;

namespace asd1231.controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
                return "asdasd";
        }
        public string Saat()
        {
                var saat = DateTime.Now.ToString("HH:MM:ss");
                return saat;
        }
    }
}
