using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LR2ASP.Models;

namespace LR2ASP.Controllers
{
    public class HomeController : Controller
    {

        SportGoods[] equipment = {
         new SportGoods {Good_Id = 1, Name = "Бутси", Price = 400, Brand="Nike", Count=12, Category="Взуття"},
         new SportGoods {Good_Id = 2, Name = "Сноуборд", Price = 4500, Brand="Frost", Count=3, Category="Транспорт"},
         new SportGoods {Good_Id = 3, Name = "Велосипед",Price = 7000, Brand="BMW", Count=5,  Category="Транспорт"},
         new SportGoods {Good_Id = 4, Name = "Тенісна ракетка",Price = 700, Brand="Collapse", Count=4, Category="Інвентар"},
         new SportGoods {Good_Id = 5, Name = "Мячик для гольфу",Price = 530, Brand="Golf Club", Count=23, Category="Інвентар"},
     };

        public ActionResult Index()
        {
            return View(equipment);
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