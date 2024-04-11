using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication3.Areas.Admin.Models;

namespace WebApplication3.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();
            
            list.Add(new CategoryClass
            {
                categoryname = "Yazılım",
                categorycount = 14

            }); 
            list.Add(new CategoryClass
            {
                categoryname = "Teknoloji",
                categorycount = 10
            });
            list.Add(new CategoryClass
            {
                categoryname = "Tiyatro",
                categorycount = 15
            });

            list.Add(new CategoryClass
            {
                categoryname = "Film&Dizi",
                categorycount = 10
            });
            list.Add(new CategoryClass
            {
                categoryname = "Oyun",
                categorycount = 6
            });
            list.Add(new CategoryClass
            {
                categoryname = "Spor",
                categorycount = 5
            });
            list.Add(new CategoryClass
            {
                categoryname = "Seyehat",
                categorycount = 12
            });
            list.Add(new CategoryClass
            {
                categoryname = "Donanım",
                categorycount = 3
            });
            return Json(new { jsonlist = list });
        }
    }
}
