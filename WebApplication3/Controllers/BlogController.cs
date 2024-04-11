﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication3.Controllers
{

	public class BlogController : Controller
	{
		BlogManager bm = new BlogManager(new EfBlogRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        Context c = new Context();

		[AllowAnonymous]
        public IActionResult Index()
		{
			var values = bm.GetBlogListWithCategory();
			return View(values);
		}

        [AllowAnonymous]
        public IActionResult BlogReadAll(int id)
		{
			ViewBag.i = id;
			var values = bm.GetBlogByID(id);
			return View(values);
		}
		public IActionResult BlogListByWriter()

		{
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = bm.GetListWithCategoryByWriterBm(writerID);
			return View(values);
		}

		[HttpGet]
		public IActionResult BlogAdd()
		{
			
			List<SelectListItem> categoryvalues = (from x in cm.GetList()
												   select new SelectListItem
												   { 
												       Text = x.CategoryName,
												       Value = x.CategoryID.ToString() 
												   }).ToList();
			ViewBag.cv = categoryvalues;
			return View();
		}
		[HttpPost]
        public IActionResult BlogAdd(Blog blog)
        {

            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();

            BlogValidator bv = new BlogValidator();
            ValidationResult results = bv.Validate(blog);
            if (results.IsValid)
            {

                blog.BlogStatus = true;
				blog.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
				blog.WriterID = writerID;
				bm.TAdd(blog);
                return RedirectToAction("BlogListByWriter", "Blog");

            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,
                        item.ErrorMessage);
                }
            }
            return View();
            
        }
		public IActionResult DeleteBlog(int id)
		{
			var blogvalue = bm.TGetById(id);
			bm.TDelete(blogvalue);
			return RedirectToAction("BlogListByWriter");
;		}

		[HttpGet]
		public IActionResult EditBlog(int id)
		{
			var blogvalue = bm.TGetById(id);

            List<SelectListItem> categoryvalues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryvalues;
            return View(blogvalue);
		}

        [HttpPost]
        public IActionResult EditBlog(Blog blog)
		{
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            blog.WriterID = writerID;
			blog.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			blog.BlogStatus = true;
			bm.TUpdate(blog);
			return RedirectToAction("BlogListByWriter");
		}

    }
}
