﻿using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Controllers
{
	public class LoginController : Controller
	{
		[AllowAnonymous]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		[AllowAnonymous]
		public IActionResult Index(Writer p)
		{
			Context c = new Context();
			var datavalue = c.Writers.FirstOrDefaultAsync(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
			if (datavalue != null)
			{
				HttpContext.Session.SetString("username", p.WriterMail);
				return RedirectToAction("Index", "Writer");
			}
			else
			{
				return View();
			}
{			
		}

	}
  }
}
