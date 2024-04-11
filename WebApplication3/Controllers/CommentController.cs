using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApplication3.Controllers
{
	[AllowAnonymous]
	public class CommentController : Controller
		
	{
		CommentManager cm = new CommentManager(new EfCommentRepository());

		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}

		[HttpPost]
		public PartialViewResult PartialAddComment(Command comment)
		{
			comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			comment.CommentStatus = true;
			comment.BlogID = 9;
			cm.CommandAdd(comment);
			return PartialView();
		}
		public PartialViewResult CommentListByBLog(int id)
		{
			var values = cm.GetList(id);
			return PartialView(values);
		}
	}
}
