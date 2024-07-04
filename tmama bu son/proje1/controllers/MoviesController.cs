using Microsoft.AspNetCore.Mvc;
using System;

namespace proje1.controllers
{       //controller
    public class MoviesController : Controller
    {
        //action
        //http://localhost:63178/movies/index
        public string Index()
        {
            return "movie index";
        }
        //http://localhost:63178/movies/list
        public string List()
        {
            return "film Listesi";
        }
        //http://localhost:63178/movies/details
        public int Details()
        {
           return 43;
        }
        //http://localhost:63178/movies/Information
        public string Information()
        {
            return "movie information";
        }

    }
}
