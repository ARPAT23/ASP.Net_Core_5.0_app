using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminCommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());
        [HttpGet]
        public IActionResult Index()
        {
            var values = commentManager.GetCommentWithBlog();
            return View(values);
        }

        [HttpPost]
        public IActionResult CommentDelete(int id)
        {
            var value = commentManager.CommandGetById(id);
            if (value.IsDelete)
            {
                value.IsDelete = false;
            }
            else
            {
                value.IsDelete = true;
            }
            commentManager.TUpdate(value);
            return View();
        }
    }
}
