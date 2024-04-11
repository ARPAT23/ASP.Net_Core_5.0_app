﻿using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebApplication3.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic2 : ViewComponent
    {

        Context c = new Context();
        public IViewComponentResult Invoke()
        {

            ViewBag.LastBlogTitle = c.Blogs.OrderByDescending(x => x.BlogID).Select(x => x.BlogTitle).Take(1).FirstOrDefault();

            return View();
        }
    }
}