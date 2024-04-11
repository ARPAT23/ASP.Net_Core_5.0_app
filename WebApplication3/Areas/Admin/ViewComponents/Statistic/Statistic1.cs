using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace WebApplication3.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1 : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.BlogCount = bm.GetList().Count();
            ViewBag.MessageCount = c.Contacts.Count();
            ViewBag.CommentCount = c.Coments.Count();


            string api = "f3986874872938c4079a52848a33e565";
            string connection =
                "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.HavaDurumu = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;


            return View();
        }
    }
}
