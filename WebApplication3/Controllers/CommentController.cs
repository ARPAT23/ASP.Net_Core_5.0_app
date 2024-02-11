using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApplication3.Controllers
{
	public class CommentController : Controller
		
	{
		CommentManager cm = new CommentManager(new EfCommentRepository());

		public CommentManager Cm { get => cm; set => cm = value; }

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
		public PartialViewResult PartialAddComment(Command p)
		{
			p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			p.CommentStatus = true;
			p.BlogID = 9;
			cm.CommandAdd(p);
			return PartialView();
		}
		public PartialViewResult CommentListByBLog(int id)
		{
			var values = cm.GetList(id);
			return PartialView(values);
		}
	}
}
